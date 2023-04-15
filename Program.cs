
//Zadanie 1
Console.WriteLine("Zadanie 1:");
int a = 5;
int b = 5;
if (a == b)
{
    Console.WriteLine("{0} i {1} są równe.", a, b);
}
else
{
    Console.WriteLine("{0} i {1} są różne.", a, b);

   
}
Console.WriteLine("------------------------------");
Console.WriteLine("Zadanie 2:");
a = 15;
b = a % 2;
//int b = 5;
if (b == 0)
{
    Console.WriteLine("{0} jest liczbą parzystą", a);
}
else
{
    Console.WriteLine("{0} jest liczbą nieparzystą", a);


}
Console.WriteLine("------------------------------");
Console.WriteLine("Zadanie 3:");
a = 14;
//b = a % 2;
//int b = 5;
if (a > 0)
{
    Console.WriteLine("{0} jest liczbą dodatnią", a);
}
else if (a < 0) 
{
    Console.WriteLine("{0} jest liczbą ujemną", a);


}
Console.WriteLine("------------------------------");
