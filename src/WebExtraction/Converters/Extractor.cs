using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using WebExtraction.Models;

namespace WebExtraction.Converters
{
    public class Extractor
    {
        private readonly IConfiguration _configuration;

        public Extractor()
        {
            _configuration = Configuration.Default;
        }

        public async Task<string> ExtractHotelInfo(string source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            using var context = BrowsingContext.New(_configuration);
            using var document = await context.OpenAsync(req => req.Content(source));

            var hotelName = GetHotelName(document);
            var address = GetHotelAddress(document);
            var stars = GetHotelStars(document);
            var reviewPoints = GetHotelReviewPoints(document);
            var reviewsCount = GetHotelReviewsCount(document);
            var description = GetHotelDescription(document);
            var roomCategories = GetHotelRoomCategories(document).ToArray();
            var alternativeHotels = GetAlternativeHotels(document).ToArray();

            var hotel = new HotelDto(
                Name: hotelName,
                Address: address,
                Stars: stars,
                ReviewPoints: reviewPoints,
                ReviewsCount: reviewsCount,
                Description: description,
                RoomCategories: roomCategories,
                AlternativeHotels: alternativeHotels
            );

            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };

            var jsonString = JsonSerializer.Serialize(hotel, options);

            Console.WriteLine(jsonString);

            return jsonString;
        }

        private string GetHotelName(IDocument document)
        {
            string hotelName = document
                .QuerySelectorAll("span")
                .GetElementById("hp_hotel_name")?
                .TextContent?
                .Trim()
                ?? string.Empty;

            return hotelName;
        }

        private string GetHotelAddress(IDocument document)
        {
            string address = document
                .QuerySelectorAll("span")
                .GetElementById("hp_address_subtitle")?
                .TextContent?
                .Trim()
                ?? string.Empty;

            return address;
        }

        private int GetHotelStars(IDocument document)
        {
            string ratingsStars = document
                .QuerySelectorAll("span")
                .FirstOrDefault(element => element.ClassName == "hp__hotel_ratings__stars hp__hotel_ratings__stars__clarification_track")?
                .FirstElementChild?
                .ClassName?
                .Split(' ')
                .FirstOrDefault(s => s.StartsWith("ratings_stars_"));

            ratingsStars = ratingsStars?[^1..];

            int stars = 0;
            if (!int.TryParse(ratingsStars, out stars))
            {
                //TODO: use a logger
                Console.WriteLine($"Unable to convert hotel classification '{ratingsStars}' to an integer.");
            }

            return stars;
        }

        private double GetHotelReviewPoints(IDocument document)
        {
            var scoreCard = document
                .QuerySelectorAll("div")
                .GetElementById("js--hp-gallery-scorecard");

            var scoreValue = scoreCard?
                .QuerySelectorAll("span")
                .FirstOrDefault(element => element.ClassName == "average js--hp-scorecard-scoreval")?
                .TextContent;

            double reviewPoints = 0;
            var style = NumberStyles.Float;
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            if (!double.TryParse(scoreValue, style, formatter, out reviewPoints))
            {
                //TODO: use a logger
                Console.WriteLine($"Unable to convert review points '{scoreValue}' to a number.");
            }

            return reviewPoints;
        }

        private int GetHotelReviewsCount(IDocument document)
        {
            var scoreCard = document
                .QuerySelectorAll("div")
                .GetElementById("js--hp-gallery-scorecard");

            var reviews = scoreCard?
                .GetElementsByClassName("count")
                .FirstOrDefault()?
                .TextContent;

            int reviewsCount = 0;
            if (!int.TryParse(reviews, out reviewsCount))
            {
                //TODO: use a logger
                Console.WriteLine($"Unable to convert a number of reviews '{reviews}' to an integer.");
            }

            return reviewsCount;
        }

        private string GetHotelDescription(IDocument document)
        {
            var summary = document
                .QuerySelectorAll("div")
                .GetElementById("summary")?
                .Descendents<IHtmlParagraphElement>()
                .Select(p => p.TextContent)
                ?? Array.Empty<string>();

            var description = string.Join(Environment.NewLine, summary);
            return description;
        }

        private IEnumerable<string> GetHotelRoomCategories(IDocument document)
        {
            var roomsTable = document
                .QuerySelectorAll("table")
                .GetElementById("maxotel_rooms");

            var roomsTableRows = roomsTable?
                .QuerySelector("tbody")
                .Children;

            var roomCategories = roomsTableRows?
                .Select(row => row.GetElementsByClassName("ftd"))
                .SelectMany(row => row.Select(cell => cell.TextContent?.Trim()))
                ?? Array.Empty<string>();

            return roomCategories;
        }

        private IEnumerable<AlternativeHotelDto> GetAlternativeHotels(IDocument document)
        {
            var alternativeHotels = new List<AlternativeHotelDto>();
            var altHotelsCells = GetAltHotelsCells(document).ToList();

            foreach (var cell in altHotelsCells)
            {
                var name = GetAltHotelName(cell);
                var stars = GetAltHotelStars(cell);
                var reviewPoints = GetAltHotelReviewPoints(cell);
                var reviewsCount = GetAltHotelReviewsCount(cell);
                var description = GetAltHotelDescription(cell);

                var altHotel = new AlternativeHotelDto(
                    Name: name,
                    Stars: stars,
                    ReviewPoints: reviewPoints,
                    ReviewsCount: reviewsCount,
                    Description: description
                );

                alternativeHotels.Add(altHotel);
            }

            return alternativeHotels;
        }

        private IEnumerable<IHtmlTableDataCellElement> GetAltHotelsCells(IDocument document)
        {
            var altHotelsTable = document
                .QuerySelectorAll("table")
                .GetElementById("althotelsTable");

            var altHotelsCells = altHotelsTable?
                .Descendents<IHtmlTableRowElement>()
                .SelectMany(row => row.Descendents<IHtmlTableDataCellElement>())
                ?? Array.Empty<IHtmlTableDataCellElement>();

            return altHotelsCells;
        }

        private string GetAltHotelName(IHtmlTableDataCellElement altHotelCell)
        {
            var name = altHotelCell
                .GetElementsByClassName("althotel_link")
                .FirstOrDefault()?
                .TextContent?
                .Trim()
                ?? string.Empty;

            return name;
        }

        private int GetAltHotelStars(IHtmlTableDataCellElement altHotelCell)
        {
            var ratingsStars = altHotelCell
                .GetElementsByClassName("b-sprite ratings_stars_5_sm")
                .FirstOrDefault(element => element.TextContent is not null && element.TextContent.EndsWith("-star hotel"))?
                .TextContent?[..1];

            int stars = 0;
            if (!int.TryParse(ratingsStars, out stars))
            {
                //TODO: use a logger
                Console.WriteLine($"Unable to convert hotel classification '{ratingsStars}' to an integer.");
            }

            return stars;
        }

        private double GetAltHotelReviewPoints(IHtmlTableDataCellElement altHotelCell)
        {
            var scoreValue = altHotelCell
                .GetElementsByClassName("average js--hp-scorecard-scoreval")
                .FirstOrDefault()?
                .TextContent;

            double reviewPoints = 0;
            var style = NumberStyles.Float;
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            if (!double.TryParse(scoreValue, style, formatter, out reviewPoints))
            {
                //TODO: use a logger
                Console.WriteLine($"Unable to convert review points '{scoreValue}' to a number.");
            }

            return reviewPoints;
        }

        private int GetAltHotelReviewsCount(IHtmlTableDataCellElement altHotelCell)
        {
            var reviews = altHotelCell
                .GetElementsByClassName("count")
                .FirstOrDefault()?
                .TextContent;

            int reviewsCount = 0;
            if (!int.TryParse(reviews, out reviewsCount))
            {
                //TODO: use a logger
                Console.WriteLine($"Unable to convert a number of reviews '{reviews}' to an integer.");
            }

            return reviewsCount;
        }

        private string GetAltHotelDescription(IHtmlTableDataCellElement altHotelCell)
        {
            var description = altHotelCell
                .GetElementsByClassName("hp_compset_description")
                .FirstOrDefault()?
                .TextContent?
                .Trim();

            return description;
        }
    }
}
