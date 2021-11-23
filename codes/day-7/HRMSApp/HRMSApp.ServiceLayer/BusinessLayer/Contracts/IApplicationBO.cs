using System.Collections.Generic;

namespace HRMSApp.ServiceLayer.BusinessLayer.Contracts
{
    public interface IApplicationBO<T>
    {
        int InsertRecord(T data);
        int ModifyRecord(T data);
        int RemoveRecord(int id);
        List<T> FetchAllRecords();
        T FetchRecord(int id);
    }
}
