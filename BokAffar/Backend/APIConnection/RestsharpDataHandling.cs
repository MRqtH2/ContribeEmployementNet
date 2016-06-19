using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationProcessing.Models.Json;
using InformationProcessing.Interfaces;
using System.Collections;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json;

namespace APIConnection
{
    /*
     * Newtonsoft.Json is used for parsing JSON to objects.
     */

    public class RestsharpDataHandling : IBookstoreService
    {

        public async Task<IEnumerable<IBook>> GetBooksAsync(string searchString)
        {
            var client = new HttpClient();
            var results = client.GetAsync("http://www.contribe.se/arbetsprov-net/books.json");
            var resultsContent = await results.Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<IBook>>(resultsContent);            
        }

        public async Task<IEnumerable<IBookStock>> GetBooksWithStockAsync(string searchString)
        {
            var client = new HttpClient();
            var results = client.GetAsync("http://www.contribe.se/arbetsprov-net/books.json");
            var resultsContent = await results.Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<IBookStock>>(resultsContent);
        }
    }
}
