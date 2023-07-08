namespace lesson3_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sonni top o'yini");
            //Console.WriteLine("");
            //int randomSon = new Random().Next(1, 100);
            //int urinishlarSoni = 1;
            //Console.Write("Son kiriting :");
            //int taxmin = Convert.ToInt32(Console.ReadLine());
            //while (taxmin != randomSon)
            //{
            //    if (taxmin > randomSon)
            //    {
            //        Console.WriteLine("Men o'ylagan son kichikroq!");
            //        Console.Write("Qaytadan son kiriting :");
            //        taxmin = Convert.ToInt32(Console.ReadLine());
            //        urinishlarSoni++;
            //    }
            //    else if (taxmin < randomSon)
            //    {
            //        Console.WriteLine("Men o'ylagan soni kattaroq!");
            //        Console.Write("Qaytadan son kiriting :");
            //        taxmin = Convert.ToInt32(Console.ReadLine());
            //        urinishlarSoni++;
            //    }
            //}

            //Console.WriteLine($"Tabriklayman siz o'ylagan sonimni " +
            //    $"{urinishlarSoni} ta urinishda topdingiz!");

            int randomNumber = new Random().Next(1, 1000);
            int taxmin = 0;
            int urinishlarSoni = 0;
            Console.WriteLine("1 dan 100 gacha bo'lgan sonlar ichidan o'ylagan sonimni toping!");
            while (taxmin != randomNumber)
            {
                Console.Write("O'ylagan sonimni toping : ");
                taxmin = Convert.ToInt32(Console.ReadLine());
                urinishlarSoni++;

                if (taxmin > randomNumber) Console.WriteLine("Kichikroq son kiriting: ");
                else if (taxmin < randomNumber) Console.WriteLine("Kattaroq son kiriting: ");
                else Console.WriteLine($"Tabriklaymiz! siz o'ylagan sonimni {urinishlarSoni} ta urinishda topdingiz!");
            }
        }
    }
}