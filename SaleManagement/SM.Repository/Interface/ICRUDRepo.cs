using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Repository.Interface
{
    public interface ICRUDRepo
    {
        Task<T> InsertEntity<T>(T entity);
        Task<T> GetEntity<T>(Guid id);
        Task<T> GetEntity<T>(Guid id, string column, string filter);
        Task<int> Update<T>(T entity);
        Task<int> Delete<T>(Guid id);
    }
}
