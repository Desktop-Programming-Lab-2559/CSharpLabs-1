# Lab 8, P1, C#, 2020
# Variant 3

## Task 1

За даними дійсними числами a і b обчислити.

```csharp
class Program
    {
        static double f(double x)
        {
            bool condition = x > 0;
            double result = condition ? 0 : 1;

            for (int i = 1; i <= 5; i++)
            {
                if (condition)
                {
                    result += Math.Pow(x, i);
                } else
                {
                    result *= Math.Pow(x, i);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            double u = f(a) + f(2) + f(b);

            Console.WriteLine(u);
            Console.ReadKey();
        }
    }
```

## Task 2

Використовуючи підпрограму наближеного знаходження визначеного інтегралу за формулою правих прямокутників, обчислити значення виразу.

```csharp
class Program
    {
        static double f(double x)
        {
            return Math.Sqrt(4*x + Math.Sin(Math.Pow(x, 1/3)));
        }

        static double integral(double a, double b, int n)
        {
            double sum = 0;
            double h = (b - a) / n;

            double ptr = a+h;

            while (ptr <= b)
            {
                sum += f(ptr) * h;
                ptr += h;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double u = integral(a, 3, n) + integral(a,b,n);

            Console.WriteLine(u);
            Console.ReadKey();
        }
    }
```

## Task 3

Нехай `x_0 = 1, x_i  = x_(i-1) + 2 * i`. Визначити `x_10`;


```csharp
class Program
    {

        static long recur(long i)
        {
            if (i == 0) return 1;

            return recur(i-1) + 2 * i;
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine(recur(10));
            Console.ReadKey();
        }
    }
```