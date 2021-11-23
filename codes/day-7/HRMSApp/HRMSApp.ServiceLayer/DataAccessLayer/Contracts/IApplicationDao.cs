using System.Collections.Generic;

namespace HRMSApp.ServiceLayer.DataAccessLayer.Contracts
{
    public interface IApplicationDao<T>
    {
        int Add(T data);
        int Update(T data);
        int Delete(int id);
        List<T> GetAll();
        T Get(int id);
    }
}
