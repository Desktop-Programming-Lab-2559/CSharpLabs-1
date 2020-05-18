using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4
{
    class DataGridSolver : ISolver
    {
        private DataGridView dataGridView;

        public DataGridSolver(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }

        public int getLargerThanNeighbours()
        {
            int columns = dataGridView.ColumnCount;
            int result = 0;

            for (int i = 0; i < columns; i++)
            {
                double item = Convert.ToDouble(dataGridView[i,0].Value);

                if (i > 0)
                {
                    double leftNeighbour = Convert.ToDouble(dataGridView[i-1, 0].Value);

                    if (leftNeighbour >= item) continue;
                }

                if (i < columns-1)
                {
                    double rightNeighbour = Convert.ToDouble(dataGridView[i + 1, 0].Value);

                    if (rightNeighbour >= item) continue;
                }

                result++;
            }

            return result;
        }
    }
}
