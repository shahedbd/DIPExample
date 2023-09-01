

namespace DIPExample.ApplyingDIP
{
    // High-level class depending on abstraction
    public class ReportGenerator
    {
        private IDataAccess _iDataAccess;

        public ReportGenerator(IDataAccess iDataAccess)
        {
            _iDataAccess = iDataAccess;
        }

        public void GenerateReport()
        {
            Console.WriteLine("Applying DIP: Generating report...");
            List<string> _GetData = _iDataAccess.GetData();
            foreach (var item in _GetData)
            {
                Console.WriteLine("Report Data: " + item);
            }
        }
    }
}
