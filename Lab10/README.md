# Lab 10, P1, C#, 2020
# Variant 3

## Task 1

Створити клас "Матриця".

Поля:
* для зберігання елементів матриці;
* для зберігання розмірності матриці;

Методи:
* введення елементів матриці
* виведення елементів матриці
* знаходження найбільшого елемента
* знаходження найменшого елемента

```csharp
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

```

## Task 2

Об’єкт “Працівник”
Поля:
* прізвище та ініціали;
* дата народження (член-клас);
* дата прийняття на роботу (член-клас);
* розмір заробітної плати

Методи:
* визначення стажу роботи працівника;
* визначення віку працівника на даний момент;
* визначення загальної виплаченої суми коштів протягом всього періоду роботи.

```csharp
class Worker
    {
        string name;
        string surname;
        DateTime birthday;
        DateTime employment;
        int salary;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }


        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public DateTime Employment
        {
            get
            {
                return employment;
            }

            set
            {
                employment = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public Worker(string name, string surname,DateTime birthday, DateTime employment, int salary)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Employment = employment;
            Salary = salary;
        }

        public int GetAge()
        {
            return (int)(DateTime.Now - Birthday).TotalDays / 365;
        }

        public int GetExperience()
        {
            return (int)(DateTime.Now - Employment).TotalDays / 365;
        }

        public int GetTotalPayment()
        {
            return GetExperience() * 12 * Salary;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
```