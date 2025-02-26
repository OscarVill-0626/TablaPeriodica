using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaPeriodica
{
    public partial class Ar : Form
    {
        public Ar()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TablaPeriodica();
            form.ShowDialog();
        }

        private void Ar_Load(object sender, EventArgs e)
        {

        }
    }
}
