using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Intefaces
{
    public interface IOperational<T>
    {
        Task createAssync(T entity);
        Task<IEnumerable<T>> readAllAssync();
        Task<T> readOneAssync(int id);
        Task updateAssync(T entity);
        Task deleteAssync(int id);
    }
}
