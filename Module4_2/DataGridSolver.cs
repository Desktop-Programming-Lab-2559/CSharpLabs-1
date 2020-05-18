using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4_2
{
    class DataGridSolver : ISolver
    {
        private DataGridView dataGridView;

        public DataGridSolver(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }

        public double getSumOfOddIndexedElements()
        {
            int columns = dataGridView.ColumnCount;
            int rows = dataGridView.RowCount;

            double sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        double value = Convert.ToDouble(dataGridView[j, i].Value);

                        sum += value;
                    }
                }
            }

            return sum;
        }
    }
}
