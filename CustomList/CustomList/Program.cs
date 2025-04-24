using CustomList.Models;
using System.Runtime.Serialization.Formatters;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var names = new CustomLists<string>();

            names.Add("Brilyant");
            names.Add("Azer");
            names.Add("Amin");
            names.Add("Nergis");
            names.Add("Nicat");
            names.Add("Azer");
            names.Add("Benjamin");


            Console.WriteLine("elave edilen adlar:");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
           
            Console.WriteLine("----------------------");

            Console.WriteLine("silinen ad:Azer");          

            names.Remove("Azer");

            Console.WriteLine("----------------------");

            Console.WriteLine("Yeni siyahi:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("----------------------");

            string foundName = names.Find(x => x == "Brilyant");
            Console.WriteLine($"Tapilan ad: {foundName}");

            Console.WriteLine("----------------------");


            CustomLists<string> startwithB = names.FindAll(x => x.StartsWith("B"));

            Console.WriteLine("B ile baslayan adlar:");

            for (int i = 0;i < startwithB.Count; i++)
            {
                Console.WriteLine(startwithB[i]);
            }

        }
    }
}
