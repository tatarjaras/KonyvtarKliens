using KonyvtarKliens.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarKliens.Services
{
    internal class Konyvtarservices
    {
        public static async Task<List<KonyvtarakDTO>> GetAll(HttpClient httpClient)
        {
            return await httpClient.GetFromJsonAsync<List<KonyvtarakDTO>>("Konyvtarak/GetAll");
        }
    }
}
