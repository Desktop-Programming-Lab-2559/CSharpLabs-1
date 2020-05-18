using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nmRows_ValueChanged(object sender, EventArgs e)
        {
            int newRowsCount = Convert.ToInt32(nmRows.Value);

            dataGridView.RowCount = newRowsCount;
        }

        private void nmColumns_ValueChanged(object sender, EventArgs e)
        {
            int newColumnsCount = Convert.ToInt32(nmColumns.Value);

            dataGridView.ColumnCount = newColumnsCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridSolver solver = new DataGridSolver(dataGridView);

            double result = solver.getSumOfOddIndexedElements();

            MessageBox.Show($"Result: {result}");
        }
    }
}
