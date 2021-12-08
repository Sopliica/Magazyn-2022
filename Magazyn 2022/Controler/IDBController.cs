using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn_2022.Controler
{
    public interface IDBController<T>
    {
        T GetById(int Id);
        void Add(T User);
        void Edit(T User);
        void DeleteById(int Id);
        List<T> GetAll();
    }
}
