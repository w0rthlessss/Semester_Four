using Lab1;
namespace Lab1_Tests
{
    [TestClass]
    public class Lab1Tests
    {
        [TestMethod]
        //“очка пересечени€ при паралельных отрезках
        public void ParalelSegments()
        {
            Segment first = new Segment(0, 0, 5, 0);
            Segment second = new Segment(0, 5, 5, 5);

            Segment result = SegmentIntersection.Intersection(first, second);
            Segment expected = new Segment(double.NaN, double.NaN, double.NaN, double.NaN);

            Assert.AreEqual(expected, result);
            
        }

        [TestMethod]
        //ќбласть пересечени€ при накладывающихс€ отрезках
        public void OverlappingSegments()
        {
            Segment first = new Segment(0, 0, 5, 5);
            Segment second = new Segment(2, 2, 7, 7);

            Segment result = SegmentIntersection.Intersection(first, second);
            Segment expected = new Segment(2, 2, 5, 5);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        //“очка пересечени€, при одном вертикальном отрезке
        public void OneVerticalSegment()
        {
            Segment first = new Segment(0, 0, 0, 5);
            Segment second = new Segment(2, 2, 7, 7);

            Segment result = SegmentIntersection.Intersection(first, second);
            Segment expected = new Segment(double.NaN, double.NaN, double.NaN, double.NaN);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        //“очка пересечени€ в общем случае
        public void IntersectingSegments()
        {
            Segment first = new Segment(-5, -5, 5, 5);
            Segment second = new Segment(-5, 5, 5, -5);

            Segment result = SegmentIntersection.Intersection(first, second);
            Segment expected = new Segment(0, 0, double.NaN, double.NaN);

            Assert.AreEqual(expected, result);
        }
    }
}