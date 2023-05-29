namespace HindelineTöö
{
    internal class Program
    {
        static void Main()
        {  
            Console.WriteLine("1. nimi");
            Console.WriteLine("2. vanus");
            Console.WriteLine("3. grupp");

            int valik = Convert.ToInt32(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    Nimi();
                    break;
                case 2:
                    Vanus();
                    break;
                case 3:
                    Grupp();
                    break;
                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        static void Nimi()
        {
            Console.WriteLine("Sisesta oma nimi:");
            string nimi = Console.ReadLine();
            Console.WriteLine("Tere, " + nimi);
        }

        static void Vanus()
        {
            Console.WriteLine("Sisesta oma vanus");
            int vanus = Convert.ToInt32(Console.ReadLine());

            if (vanus < 18)
            {
                Console.WriteLine("Sa oled alaealine");
            }
            else
            {
                Console.WriteLine("Sa oled täiskasvanu");
            }
        }

        static void Grupp()
        {
            Console.WriteLine("Sisesta oma grupp:");
            string grupp = Console.ReadLine();

            if (grupp == "TITpe22")
            {
                Console.WriteLine("Sa oled õiges gruppis.");
            }
            else
            {
                Console.WriteLine("Sa ei ole õiges gruppis.");
            }
        }
    }
}