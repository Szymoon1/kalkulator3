namespace kalkulator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w kalkulator");
            
            
            Start:
                Console.WriteLine("Liczymy?");
                string n = Console.ReadLine();
                Console.Clear();

                if (n == "tak" || n == "TAK")
                {
                    Console.WriteLine("Wybierz jakie działanie chcesz wykonać: \n1-Dodawanie \n2-Odejmowanie \n3-Mnożenie \n4-Dzielenie \n5-Wyjście");
                    int d = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (d == 1)
                    {
                        Console.WriteLine("Podaj pierwszą liczbę \n_");
                        int a = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Podaj drugą liczbę");
                        Console.WriteLine("{0}+_", a);
                        int b = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Wynik to:{0}", a + b);
                    goto Start;
                    }
                    else if (d == 2)
                    {
                        Console.WriteLine("Podaj pierwszą liczbę \n_");
                        int a = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Podaj drugą liczbę");
                        Console.WriteLine("{0}-_", a);
                        int b = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Wynik to:{0}", a - b);
                    goto Start;
                    }
                    else if (d == 3)
                    {
                        Console.WriteLine("Podaj pierwszą liczbę \n_");
                        int a = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Podaj drugą liczbę");
                        Console.WriteLine("{0}*_", a);
                        int b = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Wynik to:{0}", a * b);
                    goto Start;
                    }
                    else if (d == 4)
                    {
                        Console.WriteLine("Podaj pierwszą liczbę \n_");
                        int a = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Podaj drugą liczbę");
                        Console.WriteLine("{0}/_", a);
                        int b = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Wynik to:{0}", a / b);
                    goto Start;
                    }
                    else if (d == 5)
                    {
                        Console.Clear();
                        goto End;
                    }
                    else
                    {
                        Console.WriteLine("Brak operacji z listy");
                    goto Start;
                    }
                }
                else if (n == "nie" || n == "NIE")
                {
                    Console.Clear();
                    goto End;
                }
            End:
            Console.WriteLine("Do zobaczenia kiedy indziej");
            Console.ReadKey();
        }
    }
}