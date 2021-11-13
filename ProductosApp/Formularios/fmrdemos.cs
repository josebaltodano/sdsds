using pratica.Entities;
using pratica.pratica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{
    public partial class fmrdemos : Form
    {
        private IProductorepositorio productRepository;
        public fmrdemos(IProductorepositorio product)
        {
            this.productRepository = product;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Producto p = new Producto()
                {
                    Id = productRepository.FinAll().Count == 0 ? 1 : productRepository.FinAll().Last().Id + 1,
                    Nombre = $"Leche de Soya {(i + 1)}",
                    Descripcion = $"0% grasa {(i + 1)}L",
                    UnidadMedida = pratica.Enums.UnidadMedida.Litros
           

                };
                productRepository.create(p);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Producto> productos = productRepository.FinAll(a => a.Nombre.Contains("soya"));

            dgbProducts.DataSource = productos;
        }
    }
}
