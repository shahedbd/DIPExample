namespace DIPExample.ViolatingDIP
{
    // High-level class
    public class ReportGenerator
    {
        private Database _Database;

        public ReportGenerator()
        {
            _Database = new Database();
        }

        public void GenerateReport()
        {
            Console.WriteLine("Generating report...");
            List<string> _GetData = _Database.GetData();
            foreach (var item in _GetData)
            {
                Console.WriteLine("Report Data: " + item);
            }
        }
    }
}
