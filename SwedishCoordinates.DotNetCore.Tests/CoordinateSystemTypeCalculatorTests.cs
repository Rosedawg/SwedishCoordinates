using NUnit.Framework;

namespace SwedishCoordinates.Tests
{
    [TestFixture]
    public class CoordinateSystemTypeCalculatorTests
    {
        /*
            SWEREF 99 TM	N 6534702	E 265458
            RT90	X 6539796	Y 1219001
            WGS84 dec	58,887857°	10,929260°

            SWEREF 99 TM	N 6130185	E 393437
            RT90	X 6133534	Y 1342266
            WGS84 dec	55,306522°	13,321236°

            SWEREF 99 TM	N 6600328	E 763728
            RT90	X 6599414	Y 1718236
            WGS84 dec	59,458372°	19,654854°

            SWEREF 99 TM	N 7330648	E 917405
            RT90	X 7327815	Y 1881063
            WGS84 dec	65,822498°	24,159249°

            SWEREF 99 TM	N 7671027	E 721007
            RT90	X 7670775	Y 1689086
            WGS84 dec	69,059755°	20,547493°

            SWEREF 99 TM	N 7289089	E 476058
            RT90	X 7291923	Y 1439110
            WGS84 dec	65,722594°	14,478164°         

            SWEREF 99 TM	N 6274430	E 337417
            RT90	X 6275247	Y 1288008
            WGS84 dec	56,600000°	12,346816°

            SWEREF 99 TM	N 6274430	E 615001
            RT90	X 6275247	Y 1565594
            WGS84 dec	56,600000°	16,873183°
         */

        // RT90 Test Cases
        [TestCase(6539796, 1219001, ExpectedResult = CoordinateSystemType.Rt90)]
        [TestCase(6133534, 1342266, ExpectedResult = CoordinateSystemType.Rt90)]
        [TestCase(6599414, 1718236, ExpectedResult = CoordinateSystemType.Rt90)]
        [TestCase(7327815, 1881063, ExpectedResult = CoordinateSystemType.Rt90)]
        [TestCase(7670775, 1689086, ExpectedResult = CoordinateSystemType.Undefined)] // Inconclusive with WebMercator position
        [TestCase(7291923, 1439110, ExpectedResult = CoordinateSystemType.Rt90)]
        [TestCase(6270828, 1439110, ExpectedResult = CoordinateSystemType.Rt90)]
        [TestCase(6270828, 1565594, ExpectedResult = CoordinateSystemType.Rt90)]

        // SWEREF99 Test Cases
        [TestCase(6534702, 265458, ExpectedResult = CoordinateSystemType.Sweref99)]
        [TestCase(6130185, 393437, ExpectedResult = CoordinateSystemType.Sweref99)]
        [TestCase(6600328, 763728, ExpectedResult = CoordinateSystemType.Sweref99)]
        [TestCase(7330648, 917405, ExpectedResult = CoordinateSystemType.Sweref99)]
        [TestCase(7671027, 721007, ExpectedResult = CoordinateSystemType.Sweref99)]
        [TestCase(7289089, 476058, ExpectedResult = CoordinateSystemType.Sweref99)]
        [TestCase(6270013, 337417, ExpectedResult = CoordinateSystemType.Sweref99)]
        [TestCase(6270013, 615001, ExpectedResult = CoordinateSystemType.Sweref99)]

        // Wgs84 Test Cases
        [TestCase(58.887857, 10.929260, ExpectedResult = CoordinateSystemType.Wgs84)]
        [TestCase(55.306522, 13.321236, ExpectedResult = CoordinateSystemType.Wgs84)]
        [TestCase(59.458372, 19.654854, ExpectedResult = CoordinateSystemType.Wgs84)]
        [TestCase(65.822498, 24.159249, ExpectedResult = CoordinateSystemType.Wgs84)]
        [TestCase(69.059755, 20.547493, ExpectedResult = CoordinateSystemType.Wgs84)]
        [TestCase(65.722594, 14.478164, ExpectedResult = CoordinateSystemType.Wgs84)]
        [TestCase(56.560306, 12.346816, ExpectedResult = CoordinateSystemType.Wgs84)]
        [TestCase(56.560306, 16.873183, ExpectedResult = CoordinateSystemType.Wgs84)]

        // WebMercator Test Cases
        [TestCase(8156188, 1224086, ExpectedResult = CoordinateSystemType.WebMercator)]
        [TestCase(7421584, 1496457, ExpectedResult = CoordinateSystemType.Undefined)] // Inconclusive with RT90 position
        [TestCase(8280125, 2232188, ExpectedResult = CoordinateSystemType.WebMercator)]
        [TestCase(9828434, 2772825, ExpectedResult = CoordinateSystemType.WebMercator)]
        [TestCase(10769373, 2338003, ExpectedResult = CoordinateSystemType.WebMercator)]
        [TestCase(9801332, 1611702, ExpectedResult = CoordinateSystemType.WebMercator)]
        [TestCase(7670775, 1374441, ExpectedResult = CoordinateSystemType.Undefined)] // Inconclusive with RT90 position
        [TestCase(7670775, 1878314, ExpectedResult = CoordinateSystemType.Undefined)] // Inconclusive with RT90 position
        public CoordinateSystemType GetCoordinateSystemType(double lat, double lng)
        {
            var calc = new WebMercatorCalculator();
            var str = calc.LatitudeToY(lat) + "," + calc.LongitudeToX(lng);
            return new CoordinateSystemTypeCalculator().GetCoordinateSystemType(lat, lng);
        }
    }
}
