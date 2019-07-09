using ConsumApi.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumApi.Entity
{
    class EntityResults
    {
        //este es mi servicio
        public ObservableCollection<Usuario> getResults()
        {

            ObservableCollection<Usuario> usuarios = new ObservableCollection<Usuario>();
          
            WebClient webClient = new WebClient();

            var response = webClient.DownloadString("https://randomuser.me/api/?results=20");
           var Person= JsonConvert.DeserializeObject<RootObject>(response);
            foreach (var i in Person.results) {
                Usuario users = new Usuario();
                users.Last = i.name.last;
                users.First = i.name.first;
                users.Medium = i.picture.medium;
                users.Phone = i.phone;
                users.Email = i.email;
                users.Title = i.name.title;
                usuarios.Add(users);
            }
            return usuarios;

        }

    }
}
