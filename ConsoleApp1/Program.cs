using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int size = 20;
            int[] arr = new int[size];
            arr= Rand(size, arr);
            string Chet = "";
            string NeChet = "";
            
            
            for (int i = 0; i < size; i++)
            {
                if (arr[i]%2==0)
                {
                    Chet += arr[i];
                    Chet += " ";
                }
                else
                {
                    NeChet += arr[i];
                    NeChet += " ";
                }
            } 
            Console.WriteLine(Chet);
            Console.WriteLine(NeChet);
            Chet = ChetRep(Chet);
            NeChet = NeChetRep(NeChet);
            Console.WriteLine(Chet);
            Console.WriteLine(NeChet);
            Chet.Trim();
            NeChet.Trim();
            string[] arrChet = Chet.Split(" ");
            int l = arrChet.Length;
            int count1 = 0;
            for (int i = 0; i < l; i++)
            {
                if(arrChet[i]=="D"|| arrChet[i] == "H" || arrChet[i] == "J")
                {
                    count1++;
                }
            }
            Chet= string.Join(' ', arrChet);
            string[] arrNeChet = Chet.Split(" ");
            int l1 = arrChet.Length;
            int count2 = 0;
            for (int i = 0; i < l1; i++)
            {
                if (arrNeChet[i] == "A" || arrNeChet[i] == "E" || arrNeChet[i] == "I")
                {
                    count2++;
                }
            }
            NeChet = string.Join(' ', arrNeChet);
            if(count1>count2)
            {
                Console.WriteLine($"the first array has more capital letters");
                Console.WriteLine(Chet);
            }
            else
            {
                Console.WriteLine($"the second array has more capital letters");
                Console.WriteLine(NeChet);
            }
            Console.WriteLine("");
            Console.WriteLine(Chet);
            Console.WriteLine(NeChet);
        }
        static int[] Rand(int size, int[] arr)
        {

            var r = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = r.Next(1, 26);
            }
            return arr;
        }
        static void Show(int size, int[] arr)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static string NeChetRep(string NeChet)
        {
            NeChet = NeChet.Replace("25", "y");
            NeChet = NeChet.Replace("23", "w");
            NeChet = NeChet.Replace("21", "u");
            NeChet = NeChet.Replace("19", "s");
            NeChet = NeChet.Replace("17", "q");
            NeChet = NeChet.Replace("15", "o");
            NeChet = NeChet.Replace("13", "m");
            NeChet = NeChet.Replace("11", "k");
            NeChet = NeChet.Replace("9", "I");
            NeChet = NeChet.Replace("7", "g");
            NeChet = NeChet.Replace("5", "E");
            NeChet = NeChet.Replace("3", "c"); 
            NeChet = NeChet.Replace("1", "A");
            return NeChet;
        }
        static string ChetRep(string Chet)
        {
            Chet = Chet.Replace("26", "z");
            Chet = Chet.Replace("24", "x");
            Chet = Chet.Replace("22", "v");
            Chet = Chet.Replace("20", "t");
            Chet = Chet.Replace("18", "r");
            Chet = Chet.Replace("16", "p");
            Chet = Chet.Replace("14", "n");
            Chet = Chet.Replace("12", "l");
            Chet = Chet.Replace("10", "J");
            Chet = Chet.Replace("8", "H");
            Chet = Chet.Replace("6", "f");   
            Chet = Chet.Replace("4", "D");
            Chet = Chet.Replace("2", "b");
            return Chet;
        }
    }
}

