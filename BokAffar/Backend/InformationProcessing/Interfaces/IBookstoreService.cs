using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationProcessing.Interfaces
{
    public interface IBookstoreService
    {
        Task<IEnumerable<IBook>> GetBooksAsync(string searchString);
        Task<IEnumerable<IBookStock>> GetBooksWithStockAsync(string searchString);
    }
}
