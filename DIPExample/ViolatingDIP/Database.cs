
namespace DIPExample.ViolatingDIP
{
    // Low-level class
    public class Database
    {
        public List<string> GetData()
        {
            return new List<string> { "Report Data 01", "Report Data 02", "Report Data 03" };
        }
    }
}
