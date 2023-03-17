namespace IndianStateCensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Indian State Census Analyser Problem");

            string filePath = "D:\\Bridgelabz\\.netrepo\\IndianStatesCensusAnalyserProblem\\IndianStatesCensusAnalyserProblem\\StateCensus.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int numberOfRecords = analyser.LoadDataFromCSV();
            Console.WriteLine("Number of records in the file: " + numberOfRecords);
        }
    }
}