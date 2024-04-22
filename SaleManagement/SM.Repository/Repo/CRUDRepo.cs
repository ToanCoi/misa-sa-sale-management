using SM.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Repository.Repo
{
    public class CRUDRepo : ICRUDRepo
    {
        public Task<int> Delete<T>(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetEntity<T>(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetEntity<T>(Guid id, string column, string filter)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertEntity<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
