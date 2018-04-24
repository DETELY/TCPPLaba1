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
    public partial class Form2 : Form
    {
        Form1 f = null;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fKMasterHoldingsBindingSource.DataSource = f.holdingsBindingSource;
            fKClientsHoldingsBindingSource.DataSource = f.holdingsBindingSource;

            

            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1DBDataSet.Master". При необходимости она может быть перемещена или удалена.
            this.masterTableAdapter.Fill(this.laba1DBDataSet.Master);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1DBDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.laba1DBDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba1DBDataSet.Industry". При необходимости она может быть перемещена или удалена.
            this.industryTableAdapter.Fill(this.laba1DBDataSet.Industry);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.exitToolStripMenuItem_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.aboutToolStripMenuItem_Click(sender, e);
        }
    }
}
