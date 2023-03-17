using IndianStateCensusAnalyser;
using IndianStatesCensusAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTes1
    {
        [TestMethod]
        public void LoadDataFromCSV_ShouldReturnNumberOfRecords()
        {
            // Arrange
            string filePath = "D:\\Bridgelabz\\.netrepo\\IndianStatesCensusAnalyserProblem\\IndianStatesCensusAnalyserProblem\\StateCensus.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int expectedNumberOfRecords = 5;

            // Act
            int actualNumberOfRecords = analyser.LoadDataFromCSV();

            // Assert
            Assert.AreEqual(expectedNumberOfRecords, actualNumberOfRecords);
        }


        [TestMethod]
        public void LoadDataFromCSV_ShouldThrowException_WhenIncorrectFileIsProvided()
        {
            // Arrange
            string filePath = "D:\\Bridgelabz\\.netrepo\\IndianStatesCensusAnalyserProblem\\IndianStatesCensusAnalyserProblem\\StateCensus.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);



            analyser.LoadDataFromCSV();
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadDataFromCSV_ShouldThrowException_WhenDelimiterIsIncorrect()
        {
            // Arrange
            string filePath = "D:\\Bridgelabz\\.netrepo\\IndianStatesCensusAnalyserProblem\\IndianStatesCensusAnalyserProblem\\StateCensus.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);

            // Act and Assert
            try
            {
                analyser.LoadDataFromCSV(';'); // Use semicolon as delimiter instead of comma
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
                throw;
            }
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadDataFromCSV_ShouldThrowException_WhenHeaderIsIncorrect()
        {
            // Arrange
            string filePath = "D:\\Bridgelabz\\.netrepo\\IndianStatesCensusAnalyserProblem\\IndianStatesCensusAnalyserProblem\\StateCensus.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);

            // Act and Assert
            try
            {
                analyser.LoadDataFromCSV();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
                throw;
            }
        }


    }
}