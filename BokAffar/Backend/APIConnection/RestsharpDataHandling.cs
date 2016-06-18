using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using InformationProcessing.Models.Json;
using InformationProcessing.Interfaces;
using System.Collections;
using System.Threading;

namespace APIConnection
{
    /*
     * RestSharp is used in order to avoid "re-inventing the wheel".     * 
     */

    public class RestsharpDataHandling : IBookstoreService
    {

        public async Task<IEnumerable<IBook>> GetBooksAsync(string searchString)
        {
            Task<List<IBook>> IBooks;
            var client = new RestClient("http://www.contribe.se/arbetsprov-net/");
            var request = new RestRequest("/books.json", Method.GET);
            var cancellationTokenSource = new CancellationTokenSource();
            /*
            var response = await client.GetAsync<Task<List<IBook>>>(request, r =>
            {
                if (r.ResponseStatus == ResponseStatus.Completed)
                {
                    IBooks = r.Data;
                }
            });
            */
            //return await IBooks.AsEnumerable<IBook>();

            throw new NotImplementedException();
        }

        public Task<IEnumerable<IBookStock>> GetBooksWithStockAsync(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
