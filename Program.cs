using System;

namespace diziler_array_metodları
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] sayi_dizisi = { 12, 15, 46, 48, 52, 68, 75, 46, 2, 5 };

            System.Console.WriteLine("****** Sırasız Dizi*******");

            foreach (var sayi in sayi_dizisi)
                System.Console.WriteLine(sayi);

            System.Console.WriteLine("*******Sıralı Dizi*******");

            Array.Sort(sayi_dizisi);

            foreach (var sayi in sayi_dizisi)
                System.Console.WriteLine(sayi);

            System.Console.WriteLine("*****Clear Metodu*********");

            Array.Clear(sayi_dizisi,2,2);

            foreach (var sayi in sayi_dizisi)
                System.Console.WriteLine(sayi);

            System.Console.WriteLine("******Tersine Çevirme ********");

            Array.Reverse(sayi_dizisi);

            foreach (var sayi in sayi_dizisi)
                System.Console.WriteLine(sayi);


            System.Console.WriteLine("******İndexOf*****");
            System.Console.WriteLine(Array.IndexOf(sayi_dizisi,15));


            System.Console.WriteLine("*******Array Risaze********");
            Array.Resize<int>(ref sayi_dizisi,10);
            sayi_dizisi[11] = 99;

            foreach (var sayi in sayi_dizisi)
                System.Console.WriteLine(sayi);
        }
    }
}
