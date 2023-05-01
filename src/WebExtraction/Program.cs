using WebExtraction.Converters;

namespace WebExtraction
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var path = Path.GetFullPath(
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\..\",
                    @"Resources\task 1 - Kempinski Hotel Bristol Berlin, Germany - Booking.com.html"));

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(path);
            }

            var html = File.ReadAllText(path);
            var extractor = new Extractor();
            var _ = await extractor.ExtractHotelInfo(html);
        }
    }
}