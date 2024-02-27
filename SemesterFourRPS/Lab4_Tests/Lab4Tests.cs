using Lab4;
using Windows.Devices.Lights.Effects;
namespace Lab4_Tests
{
    [TestClass]
    public class Lab4Tests
    {
        private static string testDBPath = "testDatabase.db";
        private static DatabaseManipulations database = new DatabaseManipulations(testDBPath);
        int previousRecordCount = 0;

        [TestMethod]
        public void Test1Insertion()
        {
            DatabaseValues[] records = database.ReadTable();
            previousRecordCount = records.Length;

            for(int i = 0; i < 100; i++)
            {
                database.InsertValue(
                    new DatabaseValues(
                        previousRecordCount!=0 ? records[records.Length-1].Id + i: i,
                        "Test", "Test",
                        i + 1, DateTime.Now.ToString("dd/MM/yyyy"),
                        DateTime.Now.AddDays(i+1).ToString("dd/MM/yyyy"), "Active")
                    );
            }

            records = database.ReadTable();
            Assert.IsTrue(records.Length - previousRecordCount == 100);
        }

        [TestMethod]
        public void Test2Update()
        {
            DatabaseValues[] records = database.ReadTable();
            DatabaseValues lastRecord = records[records.Length - 1];

            DatabaseValues _new = records[records.Length-1];
            _new.Value = int.MaxValue;
            database.UpdateValue(_new);

            records = database.ReadTable();
            Assert.IsTrue(lastRecord != records[records.Length - 1]);
        }

        [TestMethod]
        public void Test3Delete()
        {
            DatabaseValues[] records = database.ReadTable();
            previousRecordCount = records.Length;

            for (int i = 1; i <= 100; i++)
            {
                database.DeleteValue(records[previousRecordCount - i]);
            }

            records = database.ReadTable();
            int newRecordCount = records.Length;

            Assert.IsTrue(previousRecordCount - newRecordCount == 100);
        }
    }
}