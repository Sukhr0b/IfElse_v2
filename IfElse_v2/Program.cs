// 1

//int a = int.Parse(Console.ReadLine());

//if (a > 0)
//{
//    a++;
//    Console.WriteLine(a);
//}
//else
//{
//    a--;
//    Console.WriteLine(a);
//}


// 2

//int a = int.Parse(Console.ReadLine());

//if (a > 0)
//{
//    a++;
//    Console.WriteLine(a);
//}
//else
//{
//    a -= 2;
//    Console.WriteLine(a);
//}


// 3

//int a = int.Parse(Console.ReadLine());

//if (a > 0)
//{
//    a++;
//    Console.WriteLine(a);
//}
//else if (a < 0)
//{
//    a -= 2;
//    Console.WriteLine(a);
//}
//else if (a == 0)
//{
//    a = 10;
//    Console.WriteLine(a);
//}


// 4

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());

//if (a > 0 && b > 0 && d > 0)
//    Console.WriteLine("3 ta");
//else if (a > 0 && b > 0 && d < 0 || a > 0 && b < 0 && d > 0 || a < 0 && b > 0 && d > 0)
//    Console.WriteLine("2 ta");
//else if (a > 0 && b < 0 && d < 0 || a < 0 && b > 0 && d < 0 || a < 0 && b < 0 && d > 0)
//    Console.WriteLine("1 ta");


// 5

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());

//if (a > 0 && b > 0 && d > 0)
//    Console.WriteLine("3 ta musbat");
//else if (a > 0 && b > 0 && d < 0 || a > 0 && b < 0 && d > 0 || a < 0 && b > 0 && d > 0)
//    Console.WriteLine("2 ta musbat 1 ta manfiy");
//else if (a > 0 && b < 0 && d < 0 || a < 0 && b > 0 && d < 0 || a < 0 && b < 0 && d > 0)
//    Console.WriteLine("1 ta musbat 2 ta manfiy");
//else if (a < 0 && b < 0 && d < 0)
//    Console.WriteLine("Barchasi manfiy");


// 6

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine(a);
//}
//else if (b > a)
//{
//    Console.WriteLine(b);
//}


// 7    

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine(b);
//}
//else if (b > a)
//{
//    Console.WriteLine(a);
//}


// 8

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine(a + " " + b);
//}
//else if (b > a)
//{
//    Console.WriteLine(b + " " + a);
//}


// 9

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//if (a > b)
//{
//    a = a + b;
//    b = a - b;
//    a = a - b;
//    Console.WriteLine(a + " " + b);
//}
//else if (b > a)
//{
//    Console.WriteLine(b + " " + a);
//}


// 10

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//if (a == b)
//{
//    Console.WriteLine(0);
//}
//else if (a != b)
//{
//    Console.WriteLine(a + b);
//}


// 11

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//if (a != b)
//{
//    if (a > b)
//    {
//        Console.WriteLine(a);
//    }
//    else
//        Console.WriteLine(b);
//}
//else if (a == b)
//{
//    Console.WriteLine(0);
//}


// 12

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a > b && a > c && b > c)
//    Console.WriteLine(c);
//else if (a > b && a > c && b < c)
//    Console.WriteLine(b);
//else if (a < b && a < c && b > c || b < c)
//    Console.WriteLine(a);



// 13

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a > b && c < b || a < b && c > b)
//{
//    Console.WriteLine(b);
//}
//else if (b > a && c < a || b < a && c > a)
//{
//    Console.WriteLine(a);
//}
//else if (a > c && b < c || a < c && b > c)
//{
//    Console.WriteLine(c);
//}


// 14

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a > c && b > c)
//{
//    if (a > b)
//    {
//        Console.WriteLine($"{c} {b} {a}");
//    }
//    else if (a < b)
//    {
//        Console.WriteLine($"{c} {a} {b}");
//    }
//}
//else if (b > a && c > a)
//{
//    if (b > c)
//    {
//        Console.WriteLine($"{a} {c} {b}");
//    }
//    else if (b < c)
//    {
//        Console.WriteLine($"{a} {b} {c}");
//    }
//}
//else if (a > b && c > b)
//{
//    if (a > c)
//    {
//        Console.WriteLine($"{b} {c} {a}");
//    }
//    else if (a < c)
//    {
//        Console.WriteLine($"{b} {a} {c}");
//    }
//}



// 15

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a > c && b > c)
//{
//    if (a > b)
//    {
//        Console.WriteLine(a + b);
//    }
//    else if (a < b)
//    {
//        Console.WriteLine(a + b);
//    }
//}
//else if (b > a && c > a)
//{
//    if (b > c)
//    {
//        Console.WriteLine(b + c);
//    }
//    else if (b < c)
//    {
//        Console.WriteLine(b + c);
//    }
//}
//else if (a > b && c > b)
//{
//    if (a > c)
//    {
//        Console.WriteLine(a + c);
//    }
//    else if (a < c)
//    {
//        Console.WriteLine(a + c);
//    }
//}


// 16

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a < b && b < c && a < c)
//{
//    Console.WriteLine(a * 2);
//    Console.WriteLine(b * 2);
//    Console.WriteLine(c * 2);
//}
//else
//{
//    Console.WriteLine(-a);
//    Console.WriteLine(-b);
//    Console.WriteLine(-c);
//}


// 17

//float a = float.Parse(Console.ReadLine());
//float b = float.Parse(Console.ReadLine());
//float c = float.Parse(Console.ReadLine());

//if (a < b && b < c && a < c || a > b && b > c && a > b)
//{
//    Console.WriteLine(a * 2);
//    Console.WriteLine(b * 2);
//    Console.WriteLine(c * 2);
//}
//else
//{
//    Console.WriteLine(-a);
//    Console.WriteLine(-b);
//    Console.WriteLine(-c);
//}


// 18

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a == b)
//{
//    Console.WriteLine(c);
//}
//else if (b == c)
//{
//    Console.WriteLine(a);
//}
//else if (a == c)
//{
//    Console.WriteLine(b);
//}



// 19

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());

//if (a == b && a == c)
//{
//    Console.WriteLine(d);
//}
//else if (b == c && b == d)
//{
//    Console.WriteLine(a);
//}
//else if (a == c && d == a)
//{
//    Console.WriteLine(b);
//}
//else if (b == d && b == a)
//{
//    Console.WriteLine(c);
//}


// 20

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());


//if (a < b && a < c)
//{
//    int resB = b - a;
//    int resC = c - a;
//    if (resB < resC)
//    {
//        Console.WriteLine(b + " " + "masofa: " + resB);
//    }
//    else if (resC < resB)
//    {
//        Console.WriteLine(c + " masofa: " + resC);
//    }
//}
//else if (a > b && a > c)
//{
//    int resB = b - a;
//    int resC = c - a;
//    if (resB < resC)
//    {
//        Console.WriteLine(c + " " + "masofa: " + resC);
//    }
//    else if (resC < resB)
//    {
//        Console.WriteLine(b + " masofa: " + resB);
//    }
//}



// 21

//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());

//if (x == 0 && y == 0)
//{
//    Console.WriteLine(0);
//}
//else if (x != 0 || y != 0)
//{
//    Console.WriteLine(1 + ' ' + 2);
//}
//else if (x != 0 && y != 0)
//{
//    Console.WriteLine(3);
//}


// 22

//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());

//if (x > 0 && y > 0)
//{
//    Console.WriteLine(1);
//}
//else if (x < 0 && y > 0)
//{
//    Console.WriteLine(2);
//}
//else if (x < 0 && x < 0)
//{
//    Console.WriteLine(3);
//}
//else if (x > 0 && y < 0)
//{
//    Console.WriteLine(4);
//}


// 24

//float x = float.Parse(Console.ReadLine());

//if (x > 0)
//{
//    Console.WriteLine(Math.Sin(x));
//}
//else if (x <= 0)
//{
//    Console.WriteLine(x - 6);
//}


// 25

//float x = float.Parse(Console.ReadLine());

//if (x < -2 || x > 2)
//{
//    Console.WriteLine(2 * x);
//}
//else
//{
//    Console.WriteLine(-3 * x);
//}


// 26

//float x = float.Parse(Console.ReadLine());

//if (x <= 0)
//{
//    Console.WriteLine(-x);
//}
//else if (0 < x && x < 2)
//{
//    Console.WriteLine(x * x);
//}
//else if (x >= 2)
//{
//    x = 4;
//    Console.WriteLine(x);
//}


// 27

//float x = float.Parse(Console.ReadLine());

//if (x < 0)
//{
//    Console.WriteLine(0);
//}
//else if (x >= 0 && x < 1 || x >= 2 && x < 3)
//{
//    Console.WriteLine(1);
//}
//else if (x >= 1 && x < 2 || x >= 3 && x < 4)
//{
//    Console.WriteLine(-1);
//}


// 29

//int son = int.Parse(Console.ReadLine());

//if (son % 2 == 0 && son > 0)
//{
//    Console.WriteLine("Musbat juft son");
//}
//else if (son % 2 == 1 && son > 0)
//{
//    Console.WriteLine("Musbat toq son");
//}
//else if (son % 2 == 0 && son < 0)
//{
//    Console.WriteLine("Manfiy juft son");
//}
//else if (son % 2 != 0 && son < 0)
//{
//    Console.WriteLine("Manfiy toq son");
//}
//else if (son == 0)
//{
//    Console.WriteLine("Son nolga teng");
//}


// 30

//int n = int.Parse(Console.ReadLine());

//if (n >= 10 && n <= 99 && n % 2 == 0)
//{
//    Console.WriteLine("Ikki xonali juft son");
//}
//else if (n >= 10 && n <= 99 && n % 2 == 1)
//{
//    Console.WriteLine("Ikki xonali toq son");
//}
//else if (n >= 100 && n <= 999 && n % 2 == 0)
//{
//    Console.WriteLine("Uch xonali juft son");
//}
//else if (n >= 100 && n <= 999 && n % 2 == 1)
//{
//    Console.WriteLine("Uch xonali toq son");
//}
