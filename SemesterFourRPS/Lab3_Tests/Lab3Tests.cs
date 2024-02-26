using Lab_3;
namespace Lab3_Tests
{
    
    [TestClass]

    public class Lab3Tests
    {
        private bool CompareArrays(double[] expected, double[] actual)
        {
            const double epsilon = 0.01;
            for (int i = 0; i < expected.Length; i++)
            {
                if (Math.Abs(expected[i]) - Math.Abs(actual[i]) >= epsilon) return false;
            }
            return true;
        }

        double[] odds = new double[4];
        double[] x = FunctionPoints.GenerateX(0.5, 0, 10);
        double[] y = new double[21];
        double[] expected = new double[21];

        [TestMethod]
        /*
         Тестирование с шагом 0.5 и коэффициентами:
         A = 3; B = 1.5; C = 0.78; D = 2
         */
        public void Test1()
        {
            odds = [3, 1.5, 0.78, 2];
            
            expected = [4.36, 4.02, 3.53, 2.96, 2.39, 1.92, 1.6, 1.5, 1.62, 1.95, 2.44, 3.01, 3.58, 4.06, 4.39, 4.5, 4.39, 4.07, 3.59, 3.02, 2.45];
            y = FunctionPoints.GenerateY(x, odds);

            Assert.IsTrue(CompareArrays(expected, y));
        }

        [TestMethod]
        /*
         Тестирование с шагом 0.5 и коэффициентами:
         A = 5; B = 2; C = -1.04; D = -3
         */
        public void Test2()
        {
            odds = [5, 2, -1.04, -3];
            expected = [4.72, 5.74, 6.56, 6.98, 6.87, 6.26, 5.32, 4.3, 3.46, 3.03, 3.12, 3.7, 4.63, 5.66, 6.51, 6.96, 6.9, 6.33, 5.41, 4.38, 3.52];

            y = FunctionPoints.GenerateY(x, odds);

            Assert.IsTrue(CompareArrays(expected, y));
        }

        [TestMethod]
        /*
         Тестирование с шагом 0.5 и коэффициентами:
         A = 2; B = 3.14; C = 0.52; D = 1
         */
        public void Test3()
        {
            odds = [2, 3.14, 0.52, 1];
            expected = [4.64, 4.99, 5.14, 5.07, 4.8, 4.34, 3.72, 2.99, 2.19, 1.38, 0.61, -0.07, -0.6, -0.97, -1.13, -1.08, -0.83, -0.39, 0.22, 0.94, 1.74];

            y = FunctionPoints.GenerateY(x, odds);

            Assert.IsTrue(CompareArrays(expected, y));
        }

        [TestMethod]
        /*
         Тестирование с шагом 0.5 и коэффициентами:
         A = 4; B = 0.78; C = 1.57; D = 0
         */
        public void Test4()
        {
            odds = [4, 0.78, 1.57, 0];
            expected = [4.0, 4.55, 4.78, 4.55, 4.0, 3.45, 3.22, 3.45, 4.0, 4.55, 4.78, 4.55, 4.0, 3.45, 3.22, 3.45, 4.0, 4.55, 4.78, 4.56, 4.01];

            y = FunctionPoints.GenerateY(x, odds);

            Assert.IsTrue(CompareArrays(expected, y));
        }

        [TestMethod]
        /*
         Тестирование с шагом 0.5 и коэффициентами:
         A = 6; B = 1.04; C = 0; D = 4
         */
        public void Test5()
        {
            odds = [6, 1.04, 0, 4];
            expected = [5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21, 5.21];

            y = FunctionPoints.GenerateY(x, odds);

            Assert.IsTrue(CompareArrays(expected, y));
        }

    }
}