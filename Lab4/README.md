# Lab 4, P1, C#, 2020
# Variant 3

## Task 1

Обчислити площу трикутника, якщо трикутник задано довжиною однієї з сторін та висотою, опущеною на неї.

```csharp
			Console.Write("a = ");
            double side = Convert.ToDouble(Console.ReadLine());

            Console.Write("h = ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * side * height;

            Console.WriteLine(area);
            Console.ReadKey();
```

## Task 2

Дано дійсне число `a`. З’ясувати, чи належать це число інтервалу  `(3; 7) v [8;9) v (11; 22.4)`.

```csharp
			Console.Write("a = ");

            double a = Convert.ToDouble(Console.ReadLine());

            bool intervalOne = a > 3 && a < 7;
            bool intervalTwo = a >= 8 && a < 9;
            bool intervalThree = a > 11 && a < 22.4;

            if (intervalOne || intervalTwo || intervalThree)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
```

## Task 3

Трикутник задається координатами своїх вершин на площині. Визначити, чи є цей трикутник гострокутним.

```csharp

            Console.WriteLine("Enter x1, x2, x3, y1, y2, y3: ");

            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double a = 0;
            double b = 0;
            double c = 0;

            if (AB >= BC && AB >= AC)
            {
                c = AB;
                a = BC;
                b = AC;
            } else if (BC >= AB && BC >= AC)
            {
                c = BC;
                a = AB;
                b = AC;
            } else
            {
                c = AC;
                a = AB;
                b = BC;
            }

            if (c*c > a*a + b*b)
            {
                Console.WriteLine("Triangle is acute.");
            } else
            {
                Console.WriteLine("Triangle is NOT acute.");
            }

            Console.ReadKey();
```


## Task 4

Знайти значення y.

```
y = {
	cos(x**2 + ln(x)), x**2 + ln(x) > 0;
	1 /  x**2 + ln(x), x**2 + ln(x) < 0;
	cos(x),  x**2 + ln(x) = 0
}

```

```csharp
			Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            double compareValue = x * x + Math.Log(x);
            double y = 0;

            if (compareValue > 0)
            {
                y = Math.Cos(compareValue);
            } else if (compareValue < 0)
            {
                y = 1 / compareValue;
            } else
            {
                y = Math.Cos(x);
            }


            Console.WriteLine("y = {0}", y);
            Console.ReadKey();
```