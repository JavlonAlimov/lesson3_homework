namespace lesson3_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sonni top o'yini");
            Console.WriteLine("");
            int randomSon = new Random().Next(1, 100);
            int urinishlarSoni = 1;
            Console.Write("Son kiriting :");
            int taxmin = Convert.ToInt32(Console.ReadLine());
            while (taxmin != randomSon)
            {
                if (taxmin > randomSon)
                {
                    Console.WriteLine("Men o'ylagan son kichikroq!");
                    Console.Write("Qaytadan son kiriting :");
                    taxmin = Convert.ToInt32(Console.ReadLine());
                    urinishlarSoni++;
                }
                else if (taxmin < randomSon)
                {
                    Console.WriteLine("Men o'ylagan soni kattaroq!");
                    Console.Write("Qaytadan son kiriting :");
                    taxmin = Convert.ToInt32(Console.ReadLine());
                    urinishlarSoni++;
                }
            }

            Console.WriteLine($"Tabriklayman siz o'ylagan sonimni " +
                $"{urinishlarSoni} ta urinishda topdingiz!");
        }
    }
}