
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

Console.WriteLine("Zadanie 4:");
a = 2016;
b = a % 4;
//int b = 5;
if (b == 0)
{
    Console.WriteLine("{0} jest jest rokiem przestępnym", a);
}
else
{
    Console.WriteLine("{0} nie jest rokiem przestępnym", a);


}
Console.WriteLine("------------------------------");

Console.WriteLine("Zadanie 5:");
a = 21;
//b = a % 4;
//int b = 5;
string posel = "Posłem";
string premier = ", Premierem";
string senator = ", Senatorem";
string prezydent = ", Prezydentem";
Console.WriteLine("Masz {0} lat", a);
if (a >= 21 && a<30)
{
    Console.WriteLine("Możesz zostać {0}{1}", posel, premier);
}
else if (a>= 30 && a<35)
{
    Console.WriteLine("Możesz zostać {0}{1}{2}", posel, premier, senator);


}
else if (a >= 35)
{
    Console.WriteLine("Możesz zostać {0}{1}{2}{3}", posel, premier, senator, prezydent);


}
else
{
    Console.WriteLine("Możesz zostać programistą :)");
}
Console.WriteLine("------------------------------");
Console.WriteLine("Zadanie 6:");
a = 140;
//b = a % 4;
//int b = 5;
string krasnal = "Krasnoludem";
string sredni = "średniego wzrostu";
string wysoki = "wysoki";
string olbrzym = "olbrzymem";

Console.WriteLine("Masz {0}cm wzrostu!", a);
if (a > 0 && a < 150)
{
    Console.WriteLine("Jesteś {0}", krasnal);
}
else if (a >= 150 && a < 170)
{
    Console.WriteLine("Jesteś {0}", sredni);


}
else if (a >= 170 && a<200)
{
    Console.WriteLine("Jesteś {0}", wysoki);


}
else if (a > 200)
{
    Console.WriteLine("Jesteś {0}", olbrzym);


}
else
{
    Console.WriteLine("Nie ma Cię jeszcze w planach");
}
Console.WriteLine("------------------------------");

Console.WriteLine("Zadanie 7:");
 a = 25;
 b = 63;
int c = 79;

if (c > b && c > a)
{
    Console.WriteLine(" {0} jest największa z podanych", c);
}
Console.WriteLine("------------------------------");

Console.WriteLine("Zadanie 8:");
int matematyka = 80;
int fizyka = 71;
int chemia  = 0;

if ((matematyka > 70 && fizyka > 55 && chemia>45)||(matematyka+fizyka>150)||(matematyka+chemia > 150))
{
    Console.WriteLine(" Kandydat dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}
Console.WriteLine("------------------------------");

Console.WriteLine("Zadanie 9:");

a = 41;
switch (a)
{
    case < 0:
        Console.WriteLine("cholernie piździ");
        break;

    case (<=10): 
        Console.WriteLine("zimno");
        break;
    case (<= 20):
        Console.WriteLine("chłodno");
        break;
    case (<= 30):
        Console.WriteLine("w sam raz");
        break;
    case (<= 39):
        Console.WriteLine("zaczyna być słabo, bo gorąco");
        break;
    case (>= 40):
        Console.WriteLine("a weź wyprowadzam się na alaskę");
        break;
    default: 
        Console.WriteLine("zgubiłem termometr");
        break;


}

Console.WriteLine("------------------------------");

Console.WriteLine("Zadanie 10:");
a = 40;
b = 55;
c = 65;

if (a+b > c && c+a >b && c+b>a)
{
    Console.WriteLine("Można zbudować trójkąt !");
}
else
{
    Console.WriteLine("Nie można zbudować trójkąta");
}
Console.WriteLine("------------------------------");

Console.WriteLine("Zadanie 11:");

a = 3;
switch (a)
{
    case  1:
        Console.WriteLine("Niedostateczny");
        break;

    case 2:
        Console.WriteLine("Dopuszczający");
        break;
    case 3:
        Console.WriteLine("Dostateczny");
        break;
    case 4:
        Console.WriteLine("dobry");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry");
        break;
    case 6:
        Console.WriteLine("Celujący");
        break;
    default:
        Console.WriteLine("Coś poszło nie tak....");
        break;


}
Console.WriteLine("------------------------------");
Console.WriteLine("Zadanie 12:");

a = 4;
switch (a)
{
    case 1:
        Console.WriteLine("Poniedziałek");
        break;

    case 2:
        Console.WriteLine("Wtorek");
        break;
    case 3:
        Console.WriteLine("Środa");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 5:
        Console.WriteLine("Piątek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Niedziela");
        break;
    default:
        Console.WriteLine("Coś poszło nie tak....");
        break;


}
Console.WriteLine("------------------------------");
Console.WriteLine("Zadanie 13:"); //brak zabezpieczeń przed wpisywaniem głupot w konsoli, :) 
string wybor;
int d = 0;
double wynik;
int wynik2;
do
{
    Console.WriteLine("Podaj pierwszą liczbę");
    string liczba1 = Console.ReadLine();
    a = Int32.Parse(liczba1);
    Console.WriteLine("Podaj drugą liczbę");
    string liczba2 = Console.ReadLine();
    b = Int32.Parse(liczba2);
    Console.WriteLine("Podaj numer operacji do wykonania:");
    Console.WriteLine("1.Dodawanie");
    Console.WriteLine("2.Odejmowanie");
    Console.WriteLine("3.Mnożenie");
    Console.WriteLine("4.Dzielenie");
    Console.WriteLine("5.Exit");
    wybor = Console.ReadLine();
    d = Int32.Parse(wybor);
    if (d != 5)
    {
        switch (d)
        {
            case 1:
              wynik = a + b;
                wynik = Math.Round(wynik,0);
                
                Console.WriteLine("Wynik działania {0}+{1} = {2}", a, b, wynik);
                break;
            case 2:
                wynik = a - b;
                wynik = Math.Round(wynik, 0);
                Console.WriteLine("Wynik działania {0}-{1} = {2}", a, b, wynik);
                break;
            case 3:
                wynik = a * b;
                wynik = Math.Round(wynik, 0);
                Console.WriteLine("Wynik działania {0}*{1} = {2}", a, b, wynik);
                
                break;
            case 4:
                if (b != 0)
                {
                    wynik = ((double)a / (double)b);
                    wynik = Math.Round(wynik, 4);

                    Console.WriteLine("Wynik działania {0}/{1} = {2}", a, b, wynik);
                }
                else
                {
                    Console.WriteLine("pamiętaj cholero, nigdy nie dziel przez zero");
                }

                break;
            default: Console.WriteLine("Coś poszło nie tak...");
                break;
        }
    }

    } while (d != 5);







