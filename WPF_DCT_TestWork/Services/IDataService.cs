using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DCT_TestWork.Services
{
    public interface IDataService
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);
    }
}
