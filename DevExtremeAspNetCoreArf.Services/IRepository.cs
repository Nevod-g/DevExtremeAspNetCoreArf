using DevExtremeAspNetCoreArf.Models;

namespace DevExtremeAspNetCoreArf.Services
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T? Get(int? id);
        T Update(T arf);
    }
}
