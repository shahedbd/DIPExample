
namespace DIPExample.ApplyingDIP
{
    // Concrete implementation of IDataAccess
    public class DataAccess : IDataAccess
    {
        public List<string> GetData()
        {
            return new List<string> { "Report Data 01", "Report Data 02", "Report Data 03" };
        }
    }
}
