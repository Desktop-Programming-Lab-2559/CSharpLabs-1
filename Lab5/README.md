# Lab 5, P1, C#, 2020
# Variant 3

## Task 1

Дано дійсне число `a` і натуральне число `n`. Обчислити  a^2 * (a + 1) ^ 2 ... (a + n - 1)^2.

```csharp
Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

double P = 1;

for (int i = 0; i < n; i++) {
 P *= Math.Pow(a + i, 2);
}

Console.WriteLine(P);
Console.ReadKey();
```

## Task 2

Дано `n`. Побудувати алгоритм для визначення кількості одиниць у записі цього числа.

```csharp
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 0;

while (n != 0) {
 int digit = n % 10;
 n = n / 10;

 if (digit == 1) count++;
}

Console.WriteLine(count);
Console.ReadKey();
```

## Task 3

Перевірити справедливість рівності при заданій точності.

`ln|sin(x)| = - ln2 - cos2x - cos4x/2n - ... - cos2nx/2n`

```csharp
Console.Write("x = ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("epsilon = 10**");
double epsilon = Math.Pow(10, Convert.ToInt32(Console.ReadLine()));

double sum = Math.Log(2);
double current = Math.Cos(2 * x);
int n = 1;

while (Math.Abs(current) >= epsilon) {
 sum -= current;
 n++;
 current = (Math.Cos(2 * n * x)) / (2 * n);
}

double compareValue = Math.Log(Math.Abs(Math.Sin(x)));

Console.WriteLine("result   = {0}", sum);
Console.WriteLine("compare  = {0}", compareValue);
Console.ReadKey();
```


## Task 4

`x0 = x1 = 1, xi = x_i-1 + x_i-2, i = 2, 3, ...` 

```csharp
int x0 = 1;
int x1 = 1;
int xi = 0;

Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++) {
 xi = x0 + x1;
 x0 = x1;
 x1 = xi;
}

Console.WriteLine(xi);
Console.ReadKey();
```