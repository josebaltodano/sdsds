using System;
using System.Collections.Generic;
using System.Text;

namespace pratica.Interfaces
{
   public  interface IModel2 <E>
    {
        void Create(E e);
        int Update(E e);
        bool Delete(E e);
        E[] FinAll();
        int GetLasId();

    }
}
