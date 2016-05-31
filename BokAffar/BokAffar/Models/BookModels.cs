using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BokAffar.Interfaces;

namespace BokAffar.Models
{
    public class BookBasicInfoModel : IBook
    {
        string IBook.Title { get; }
        string IBook.Author { get; }
        decimal IBook.Price { get; }
        uint IBook.inStock { get; }
    }
    
}