using Lab2;
namespace Lab2_Tests
{
    [TestClass]
    public class Lab2Tests
    {
        [TestMethod]
        public void TestArraySort()
        {
            double[] array = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];

            ArrayManipulation.InsertionSort(ref array);

            Assert.IsTrue(ArrayManipulation.IsArraySorted(array));

        }

        [TestMethod]

        public void TestSortedArray()
        {
            double[] array = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            Assert.IsTrue(ArrayManipulation.IsArraySorted(array));
        }

        [TestMethod]

        public void ElementIsInArray()
        {
            double[] array = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];

            ArrayManipulation.InsertionSort(ref array);
            int position = ArrayManipulation.BinarySearch(array, 5);
            int expected = 5;

            Assert.AreEqual(expected, position);
        }

        [TestMethod]

        public void ElementIsNotInArray()
        {
            double[] array = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];

            ArrayManipulation.InsertionSort(ref array);
            int position = ArrayManipulation.BinarySearch(array, 100);
            int expected = -1;

            Assert.AreEqual(expected, position);
        }

        [TestMethod]

        public void BorderElement()
        {
            double[] array = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];

            ArrayManipulation.InsertionSort(ref array);
            int position = ArrayManipulation.BinarySearch(array, 9);
            int expected = 9;

            Assert.AreEqual(expected, position);
        }
    }
}