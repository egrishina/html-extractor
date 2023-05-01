using WebExtraction.Converters;

namespace WebExtractions.Tests
{
    public class ExtractorTests
    {
        private Extractor _extractor;

        [SetUp]
        public void Setup()
        {
            _extractor = new Extractor();
        }

        [Test]
        public async Task InputContainsAllData_CorrectOutput()
        {
            var source = Constants.HtmlContentWithFullData;
            var expected = Constants.JsonStringForHtmlContentWithFullData;
            var actual = await _extractor.ExtractHotelInfo(source);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public async Task InputContainsInvalidData_CorrectOutput()
        {
            var source = Constants.HtmlContentWithInvalidData;
            var expected = Constants.JsonStringForHtmlContentWithInvalidData;
            var actual = await _extractor.ExtractHotelInfo(source);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void InputIsEmpty_DoesNotThrowException()
        {
            Assert.DoesNotThrowAsync(async () => await _extractor.ExtractHotelInfo(string.Empty));
        }

        [Test]
        public void InputIsNull_ThrowsException()
        {
            var exception = Assert.ThrowsAsync<ArgumentNullException>(
                async () => await _extractor.ExtractHotelInfo(null));
            Assert.That(exception.ParamName, Is.EqualTo("source"));
        }
    }
}