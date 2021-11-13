using pratica.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace pratica.pratica
{
      public interface IProductorepositorio
    {
        void create(Producto P);
        int update(Producto P);

        bool delete(Producto P);
        List<Producto> FinAll();
        List<Producto> FinAll(Predicate<Producto> predicate);
        Producto FindAny(Predicate<Producto> predicate);

    }
}
