using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'univilleDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.univilleDataSet.clientes);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Update(this.univilleDataSet.clientes);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.univilleDataSet.clientes);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
