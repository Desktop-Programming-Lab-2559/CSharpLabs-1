using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nmCount_ValueChanged(object sender, EventArgs e)
        {
            int newColumnCount = Convert.ToInt32(nmCount.Value);
            dataGrid.ColumnCount = newColumnCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridSolver solver = new DataGridSolver(dataGrid);

            int result = solver.getLargerThanNeighbours();

            MessageBox.Show($"Result: {result}");
        }
    }
}
