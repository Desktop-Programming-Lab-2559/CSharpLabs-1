using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Task1
{
    class Matrix
    {
        private int rows;
        private int cols;

        int[,] elements;

        public int Rows {
            get {
                return rows;
            }
        }

        public int Cols
        {
            get
            {
                return cols;
            }
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;

            elements = new int[rows,cols];
        }

        public void Input()
        {
            for (int i = 0; i < rows; i ++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Matrix[{0},{1}] = ", i,j);
                    int value = Convert.ToInt32(Console.ReadLine());

                    elements[i, j] = value;
                }
            }
        }

        public void Output()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(elements[i,j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        public int FindMaximum()
        {
            int max = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int el = elements[i, j];

                    if (el > max) max = el;
                }
            }

            return max;
        }

        public int FindMinimum()
        {
            int min = elements[0,0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int el = elements[i, j];

                    if (el < min) min = el;
                }
            }

            return min;
        }
    }
}
