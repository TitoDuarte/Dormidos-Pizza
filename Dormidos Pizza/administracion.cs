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
    public partial class administracion : Form
    {
        public administracion()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void administracion_Load(object sender, EventArgs e)
        {
            recibirDatos();

        }

        private void agregar(Pizza pizza)
        {
            if (comboSucursales.Text == ga.Nombre)
            {
                ga.agregarPizza(pizza);
            }

            else if (comboSucursales.Text == jp.Nombre)
            {
                jp.agregarPizza(pizza);
            }
            
            else if (comboSucursales.Text == pg.Nombre)
            {
                pg.agregarPizza(pizza);
            }
            enviarDatos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridViewPedido.Rows.Add();

            dataGridViewPedido.Rows[n].Cells[0].Value = textNombre.Text;
            dataGridViewPedido.Rows[n].Cells[1].Value = textDescripcion.Text;
            dataGridViewPedido.Rows[n].Cells[2].Value = PrecioBox.Text;


            Pizza pizza = new Pizza(textNombre.Text, int.Parse(PrecioBox.Text), textDescripcion.Text);
            agregar(pizza);
            textNombre.Text = "";
            textDescripcion.Text = "";
            PrecioBox.Text = "";


        }



        private void PrecioBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
