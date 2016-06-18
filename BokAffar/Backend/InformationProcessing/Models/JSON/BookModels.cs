using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InformationProcessing.Interfaces;

namespace InformationProcessing.Models.Json
{
    public class BookBasicInfoModel : IBookStock
    {
        string IBook.Title { get; }
        string IBook.Author { get; }
        decimal IBook.Price { get; }
        uint IBookStock.inStock { get; }
    }

}