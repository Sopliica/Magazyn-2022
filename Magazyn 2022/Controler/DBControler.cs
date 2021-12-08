using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn_2022.Controler
{
    public class DBControler<T> : IDBController<T>
    {
        private string _connection = "Server = localhost;Database=Magazyn;User Id = TucośBędzie; Password=P@$$w0rd";

        public void Add(T User)
        {
            using (var connection = new SqlConnection(_connection))
            {
                
            }
        }

        public void DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Edit(T User)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
