using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormidos_Pizza
{
    public partial class Orden : Form
    {
        public Orden()
        {
            InitializeComponent();
        }

        Sucursales ga;
        Sucursales jp;
        Sucursales pg;

        private void recibirDatos()
        {
            Form1 form = Owner as Form1;
            ga = form.Gua;
            jp = form.Jal;
            pg = form.Pro;
        }

        private void enviarDatos()
        {
            Form1 form = Owner as Form1;
            form.Gua = ga;
            form.Jal = jp;
            form.Pro = pg;
        }


        private void Orden_Load(object sender, EventArgs e)
        {
            recibirDatos();
            comboSucursales.Items.Add(ga.Nombre);
            comboSucursales.Items.Add(jp.Nombre);
            comboSucursales.Items.Add(pg.Nombre);
        }

        private void llenartabla(String sucursal)
        {
            dataGridViewOrden.Rows.Clear();
            if (sucursal == ga.Nombre)
            {
                foreach (Pizza pizza in ga.listPizza)
                {
                    int i = 1;
                    dataGridViewOrden.Rows.Add(i, pizza.Nombre, pizza.Descripcion, ga.Nombre);
                    i++;
                }
            }

            else if (sucursal == jp.Nombre)
            {
                foreach (Pizza pizza in jp.listPizza)
                {
                    if (comboPizzas.Text == pizza.Nombre)
                    {
                        int i = 1;
                        dataGridViewOrden.Rows.Add(i, pizza.Nombre, pizza.Descripcion, jp.Nombre);
                        i++;
                    }
                }
            }

            else if (sucursal == pg.Nombre)
            {
                foreach (Pizza pizza in pg.listPizza)
                {
                    if (comboPizzas.Text == pizza.Nombre)
                    {
                        int i = 1;
                        dataGridViewOrden.Rows.Add(i, pizza.Nombre, pizza.Descripcion, pg.Nombre);
                        i++;
                    }
                }  
            }

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPizzas.Items.Clear();
            if (comboSucursales.Text == ga.Nombre)
            {
                foreach (Pizza pizza in ga.listPizza)
                {
                    comboPizzas.Items.Add(pizza.Nombre);
                    

                }
            }
            else if (comboSucursales.Text == jp.Nombre)
            {
                foreach (Pizza pizza in jp.listPizza)
                {
                    comboPizzas.Items.Add(pizza.Nombre);
                    
                }

            }
            else if (comboSucursales.Text == pg.Nombre)
            {
                foreach (Pizza pizza in pg.listPizza)
                {
                    comboPizzas.Items.Add(pizza.Nombre);
                    
                }
            }
        }
         
          private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenartabla(comboSucursales.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSucursales.Text == ga.Nombre)
            {
                foreach (Pizza pizza in ga.listPizza)
                {
                    if (comboPizzas.Text == pizza.Nombre)
                    {
                        DescripcionText.Text = pizza.Descripcion;
                        textBoxPrecio.Text = pizza.Precio.ToString();
                    }
                }
            }

            else if (comboSucursales.Text == jp.Nombre)
            {
                foreach (Pizza pizza in jp.listPizza)
                {
                    if (comboPizzas.Text == pizza.Nombre)
                    {
                        DescripcionText.Text = pizza.Descripcion;
                        textBoxPrecio.Text = pizza.Precio.ToString();
                    }
                }
            }

            else if (comboSucursales.Text == pg.Nombre)
            {
                foreach (Pizza pizza in pg.listPizza)
                {
                    if (comboPizzas.Text == pizza.Nombre)
                    {
                        DescripcionText.Text = pizza.Descripcion;
                        textBoxPrecio.Text = pizza.Precio.ToString();
                    }
                }
            }
            
        }
    }
         


    }

