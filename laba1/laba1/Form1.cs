using laba1.laba1DBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1DBDataSet.Industry". При необходимости она может быть перемещена или удалена.
            this.industryTableAdapter.Fill(this.laba1DBDataSet.Industry);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1DBDataSet.Master". При необходимости она может быть перемещена или удалена.
            this.masterTableAdapter.Fill(this.laba1DBDataSet.Master);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1DBDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.laba1DBDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1DBDataSet.Holdings". При необходимости она может быть перемещена или удалена.
            this.holdingsTableAdapter.Fill(this.laba1DBDataSet.Holdings);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog(this);
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }

        public void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
