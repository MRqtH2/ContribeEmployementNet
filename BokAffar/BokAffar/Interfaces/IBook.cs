using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokAffar.Interfaces
{
    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        decimal Price { get; }
    }

    public interface IBookStock : IBook
    {
        //Extend upon original. This was done in order to handle mapping of JSON-replies that contains Stock-information in addition to basic Book-information.
        uint inStock { get; }
    }
}
