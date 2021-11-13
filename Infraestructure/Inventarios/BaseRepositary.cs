using pratica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Inventarios
{
    public class BaseRepositary<E> : IModel2<E>
    {
        protected E[] Data;
        public void Create(E e)
        {
            throw new NotImplementedException();
        }

        public bool Delete(E e)
        {
            throw new NotImplementedException();
        }

        public E[] FinAll()
        {
            throw new NotImplementedException();
        }

        public int GetLasId()
        {
            throw new NotImplementedException();
        }

        public int Update(E e)
        {
            throw new NotImplementedException();
        }
    }
}
