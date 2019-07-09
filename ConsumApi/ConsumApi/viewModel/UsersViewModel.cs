using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConsumApi.viewModel
{
    class UsersViewModel:model.Usuario
    {
        //la clase viewModel
        public ObservableCollection<model.Usuario> listUsers{ get; set; }
        private Entity.EntityResults entity = new Entity.EntityResults();
        public UsersViewModel() {
            listUsers = entity.getResults();
        }
    }
}
