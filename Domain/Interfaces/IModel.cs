using System;
using System.Collections.Generic;
using System.Text;

namespace pratica.Interfaces
{
    public interface IModel<T> //CRUD => Create, Read, Update, Delete
    {
        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        T[] FindAll();
    }
}
