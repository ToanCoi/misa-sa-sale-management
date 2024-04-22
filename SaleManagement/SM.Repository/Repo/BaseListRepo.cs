using SM.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Repository.Repo
{
    public class BaseListRepo : IBaseListRepo
    {
        public Task<T> GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetPaging<T>(string column, string filter, int take, int litmit)
        {
            throw new NotImplementedException();
        }
    }
}
