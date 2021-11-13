using pratica.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace pratica.pratica
{
    public class ProductoRepositorio : IProductorepositorio
    {

        private List<Producto> Productos;
        public ProductoRepositorio()
        {
            Productos = new List<Producto>();
        }
        public void create(Producto P)
        {
            Productos.Add(P);
        }

        public bool delete(Producto P)
        {
            return Productos.Remove(P);
        }

        public List<Producto> FinAll()
        {
            return this.Productos;
        }

        public List<Producto> FinAll(Predicate<Producto> predicate)
        {
           if(predicate == null)
            {
                return null;
            }
            return new List<Producto>(Productos).FindAll(predicate);
        }

        public Producto FindAny(Predicate<Producto> predicate)
        {
            return new List<Producto>(Productos).Find(predicate);
        }

        public int update(Producto P)
        {
            int index = Productos.FindIndex(a => a.Id == P.Id);
            if (index < 0)
            {
                throw new Exception($"El producto no se hayo {P.Id}");
            }
            Productos.Insert(index, P);
            return index;
        }
    }
}
