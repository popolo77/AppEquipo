using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        private List<Perfil> perfiles;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EquipoNegocio equipoNegocio = new EquipoNegocio();
            List<Perfil> perfiles = equipoNegocio.NegocioList();
            dataGridView1.DataSource = perfiles;
            pictureBox1.Load(perfiles[0].Url_Imagen);
            
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Perfil seleccionado = (Perfil)dataGridView1.CurrentRow.DataBoundItem;
            pictureBox1.Load(seleccionado.Url_Imagen);
        }
    }
}
