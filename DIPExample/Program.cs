
using DIPExample.ApplyingDIP;

IDataAccess _iDataAccess = new DataAccess();
ReportGenerator _ReportGenerator = new ReportGenerator(_iDataAccess);
_ReportGenerator.GenerateReport();