using DataAccess.DataModels;

namespace DataAccess.Interfaces
{
    public interface IBBGAPI
    {
        BBGAPIHistoricalDataPoint BDH(string Security, string BBGField, DateTime StartDate, DateTime EndDate, bool FillMissingValues = false);
        BBGAPIDataPoint BDP(string Security, string BBGField);
        BBGAPIDataPoint BDP(string[] Securities, string BBGField);
        BBGAPIDataPoint BDP(string[] Securities, string[] BBGFields);
        string GetBDHAPIMessage();
        string GetBDPAPIMessage();
        bool IsBloombergConnected();
        void KillConnection();
        void StartSession();
    }
}