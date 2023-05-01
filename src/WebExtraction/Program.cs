using System.Text;
using WebExtraction.Converters;

namespace WebExtraction
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var inputPath = Path.GetFullPath(
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\..\Resources\task 1 - Kempinski Hotel Bristol Berlin, Germany - Booking.com.html"));

            if (!File.Exists(inputPath))
            {
                throw new FileNotFoundException(inputPath);
            }

            var html = File.ReadAllText(inputPath);
            var extractor = new Extractor();
            var json = await extractor.ExtractHotelInfo(html);

            var fileName = "HotelInfo.json";
            var outputPath = Path.GetFullPath(
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\..\Resources\",
                    fileName));

            if (File.Exists(outputPath))
            {
                File.Delete(outputPath);
            }

            using FileStream fs = File.Create(outputPath);
            var text = new UTF8Encoding(true).GetBytes(json);
            fs.Write(text, 0, text.Length);
        }
    }
}