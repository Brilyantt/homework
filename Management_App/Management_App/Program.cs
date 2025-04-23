namespace Management_App
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int choose;

            do
            {

                Console.WriteLine("1. Yeni xəstə əlavə et");
                Console.WriteLine("2. Yeni həkim əlavə et");
                Console.WriteLine("3. Həkimə xəstə təyin et");
                Console.WriteLine("4. Xəstələrin siyahısı");
                Console.WriteLine("5. Yeni xəstə əlavə et");
                Console.WriteLine("6. Yeni xəstə əlavə et");
                Console.WriteLine("7. Yeni xəstə əlavə et");

                Console.WriteLine("-------------------------------");

                bool input = int.TryParse(Console.ReadLine(), out choose);

                if (input)
                {
                    switch (choose)
                    {
                        case 1:


                            Console.WriteLine("Pleae enter a name");
                            string name = Console.ReadLine();

                            Console.WriteLine("Pleae enter a surname");
                            string surname = Console.ReadLine();

                            Console.WriteLine("Pleae enter a age");
                            int age = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Pleae enter a gender");
                            string gender = Console.ReadLine();
                            Enum.TryParse(gender, out Gender type);

                            Patient patient = new Patient(name, surname, age, type);

                            DBContext.AddNewPatient(patient);
                            DBContext.GetPatient();
                            break;
                    }

                }
            }
            while (choose != 0);
        }
    }
}
