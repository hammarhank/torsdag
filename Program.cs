using System.Threading.Channels;


namespace torsdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void reset()
            {
                Console.ResetColor();
                Console.Write(new string('\n', 3));
                Main(null);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Torsdag D9-ovn-1");
            Console.WriteLine("If-satser och loopar");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Välj ett övningsnummer:");
            Console.WriteLine("1. While sats till foor-loop");
            Console.WriteLine("2. Addera alla tal från 1 till angiet tal");
            Console.WriteLine("3. Oändligt övning 2");
            Console.WriteLine("4. SumQuad - Summan av alla kvadrater");
            Console.WriteLine("5. Factorial");
            Console.WriteLine("6. Samma som nr. 5");
            Console.WriteLine("7. Foor-loop");
            Console.WriteLine("8. Kvadratroten");
            Console.WriteLine("9. Kubikroten");
            Console.WriteLine("10. Kvadratrötterna och kubikroten ");
            Console.WriteLine("99. Avsluta");

            int val = Int32.Parse(Console.ReadLine());
            switch (val) 
            { 
            case 1:
                    
                    ovning1();
                    break;
            case 2:
                    ovning2();
                    break;
            case 3:
                    ovning3();
                    break;
            case 4:
                    ovning4();
                    break;
            case 5:
                    ovning5();
                    break;
            case 6:
                    ovning6();
                    break;
            case 7:
                    ovning7();
                    break;
            case 8:
                    ovning8();
                    break;
            case 9:
                    ovning9();
                    break;
            case 10:
                    ovning10();
                    break;
                case 99:
                    Console.WriteLine("Tack för mig.");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Välj ett nummer mellan 1 och 10.");
                    break;

            }

            static void ovning1()
            {
                int sum = 0;
                int n = 1;
                for(int i =0; i<10;i++)
                {
                    sum = sum + n;
                    Console.WriteLine("sum = " + sum);
                    n= n + 1;
                }
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Summan 1+2+..+9= "+sum);
                reset();
            }
            static void ovning2()
            {
                int n =1;
                int sum = 0;
                int f = 0;
                Console.WriteLine("Skriv in ett nummer som vi ska räkna addera upp till.");
                Console.Write("\nSkriv talet : ");
                f = int.Parse(Console.ReadLine());
                for (int i=0; i < f; i++)
                {
                    if (i <= f)
                    {
                        sum = sum + n;
                        Console.WriteLine("sum = "+ f +" " + sum);
                        n = n + 1;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Summan från 1-"+f+" = " + sum);
                reset();

                
            }
            static void ovning3()
            {
                while (true)
                {
                    Console.Write("Ange ett positivt heltal: ");
                    int input = int.Parse(Console.ReadLine());
                    if (input <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Du angav 0, loopen avbryts.");
                        reset();
                        break;
                    }
                    int sum = 0;
                    int n = 1;
                    while (n <= input)
                    {
                        sum += n;
                        Console.WriteLine("sum = " + sum);
                        n++;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Summan 1+2+...+" + input + " = " + sum);
                    reset();
                }


                reset();
            }
            static void ovning4()
            {
                //SumQuad
                int sum = 0;
                int n = 1;
                Console.WriteLine("Övning 4 - SumQuad - ");
                Console.WriteLine("Ange talet:");
                int inputnummer= int.Parse(Console.ReadLine());
                while (n <= inputnummer)
                {
                    sum = sum + n * n;
                    Console.WriteLine("sum = " + sum);
                    n = n + 1;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Summan av kvadraterna 1^2 + 2^2 + ... "+inputnummer +" = " + sum);
                reset();

             

                reset();
            }
            static void ovning5()
            {

                Console.WriteLine("Ange ett positivt heltal:");
                int n = int.Parse(Console.ReadLine());

                int factorial = 1;
                int i = 1;

                while (i <= n)
                {
                    factorial = factorial * i;
                    Console.WriteLine(i + " " + factorial);
                    i = i + 1;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(n + "! = " + factorial);
                reset();

                reset();
            }
            static void ovning6()
            {
                Console.WriteLine("Ange ett positivt heltal:");
                int n = int.Parse(Console.ReadLine());

                int factorial = 1;
                int i = 1;

                while (i <= n)
                {
                    factorial = factorial * i;
                    Console.WriteLine(i + " " + factorial);
                    i = i + 1;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(n + "! = " + factorial);
                

                reset();
            }
            static void ovning7()
            {
                int sum = 0;
                int n = 0;
                for (n = 1; n <= 10; n = n + 1)
                {
                    sum = sum + n;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(n + " " + sum + " " + (n * n + n) / 2);
                }

                reset();
            }
            static void ovning8()
            {
                double c = 2;
                double x = c;
                double epsilon = 0.00000001;
                while (Math.Abs(x * x - c) > epsilon)
                {
                    x = 0.5 * (x + c / x);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kvadratroten av 2 är ungefär: " + x);
                reset();
               
            }
            static void ovning9()
            {
                double c = 2;
                double x = c;
                double epsilon = 0.00000001;
                while (Math.Abs(x * x * x - c) > epsilon)
                {
                   x = (2.0 / 3) * x + c / (3 * x * x);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kubikroten av 2 är ungefär: " + x);
                reset();
            }
            static void ovning10()
            {
                for (int i = 1; i <= 10; i++)
                {
                    double kvart = kvadratroten(i);
                    double kubrt = kubikroten(i);
                    Console.WriteLine("{0}\t{1:F6}\t{2:F6}", i, kvart, kubrt);
                }
                reset();
                
            }
            static double kvadratroten(double n)
            {
                double x = n;
                double y = 1;
                double epsilon = 1e-14;

                while (Math.Abs(x - y) > epsilon)
                {
                    x = (x + y) / 2;
                    y = n / x;
                }

                return x;
            }

            static double kubikroten(double c)
            {
                double x = 1;
                double epsilon = 1e-14; 

                while (Math.Abs(x * x * x - c) > epsilon)
                {
                    x = (2.0 / 3) * x + c / (3 * x * x);
                }

                return x;
            }

        }
    }
}