using Microsoft.EntityFrameworkCore;

namespace HRMSApp.ServiceLayer.Models
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { set; get; }
    }
}
