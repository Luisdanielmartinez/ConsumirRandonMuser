using ConsumApi.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumApi.Entity
{
    class EntityResults
    {
        public async Task<List<Usuario>> getResults(string url)
        {

            List<Usuario> usuarios = new List<Usuario>();
          
            WebClient webClient = new WebClient();

            var response = webClient.DownloadString(url);
           var Person= JsonConvert.DeserializeObject<RootObject>(response);
            foreach (var i in Person.results) {
                Usuario users = new Usuario();
                users.fisrt=i.name.fisrt;
                users.last = i.name.last;
                users.medium = i.picture.medium;
                usuarios.Add(users);
            }
            return usuarios;

        }

        public HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            return client;
        }
    }
}
