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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sucursales ga = new Sucursales("Guatemala");
        Sucursales jp = new Sucursales("Jalapa");
        Sucursales pg = new Sucursales("Progreso");
        private Sucursales gua;
        private Sucursales jal;
        private Sucursales pro;

        internal Sucursales Gua { get => gua; set => gua = value; }
        internal Sucursales Jal { get => jal; set => jal = value; }
        internal Sucursales Pro { get => pro; set => pro = value; }

        private void asignar()
        {
            gua = ga;
            jal = jp;
            pro = pg;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orden frm = new Orden();
            AddOwnedForm(frm);
            frm.Show();
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            administracion frm = new administracion();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            asignar();
        }
    }
}
