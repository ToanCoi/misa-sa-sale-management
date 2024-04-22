using SM.Enitty.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Repository.Interface
{
    public interface IBaseListRepo
    {
        Task<List<T>> GetAll<T>();
        Task<List<T>> GetPaging<T>(string column, string filter, int take, int litmit);
        Task<PagingResult> GetPagingSummary<T>(string column, string filter, int take, int litmit);
    }
}
