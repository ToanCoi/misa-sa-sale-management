using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Repository.Interface
{
    public interface IBaseRepo
    {
        Task<T> GetAll<T>();
        Task<T> GetEntity<T>(Guid id);
        Task<T> GetEntity<T>(Guid id, string column, string filter);
        Task<T> GetEntities<T>(string column, string filter, int take, int litmit);
    }
}
