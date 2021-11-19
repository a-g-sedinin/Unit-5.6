using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5._6
{
    class Program
    {
        static void Main(string[] args)
        {

           PrintData(GetUserData());
           Console.ReadKey();
        }

        static (string , string , int , int , string[] ,int , string[] ) GetUserData()
        {
            Console.WriteLine("Укажите свое имя, пожалуйста.");
            string Name = Console.ReadLine();
            Console.WriteLine("Укажите свою фамилию, пожалуйста.");
            string SName = Console.ReadLine();
            Console.WriteLine("Укажите свой возраст, пожалуйста.");
            int Age = CheckValue();
            string[] PetsNames = AskPets();
            Console.WriteLine("Сколько у Вас любимых цветов?");
            int ColoursCount = CheckValue();
            string[] FavColours = Colours(ColoursCount);
            if (PetsNames != null) return (Name, SName, Age, PetsNames.Length, PetsNames, ColoursCount, FavColours);
            else
            {
                PetsNames[0] = "Нет имен";
                return (Name, SName, Age, 0, PetsNames, ColoursCount, FavColours);

            }
                
                

        }
        static void PrintData((string, string, int, int, string[], int, string[]) obj)
        {
            Console.WriteLine($"Вас зовут: {obj.Item1} {obj.Item2},Вам {obj.Item3}лет. У Вас {obj.Item4} питомцев. Их имена: ");
            foreach (string PName in obj.Item5)
            {
                Console.WriteLine($"{PName}, ");
            }
            Console.WriteLine($"\n У Вас {obj.Item6} любимых цветов. Их названия: ");
            foreach (string CName in obj.Item7)
            {
                Console.WriteLine($"{CName} ");
            }
        }
        
        
        static string[] AskPets()
        {
            int Count = 0;
            
            Console.WriteLine("Есть ли у Вас домашние животные? \n Y - ДА, N - Нет");
            string PetExist = Console.ReadLine();

            if (PetExist == "Y")
            {
                
                Console.WriteLine("Сколько их у Вас?");
                Count = CheckValue();
                return PetsNames(Count);
            }
            else if (PetExist != "N")
            {
              AskPets();
            }
            return null;
        }
        static int CheckValue ()
        {
            Console.WriteLine("Укажите корректное значение, пожалуйста.");
            string val = Console.ReadLine();
            bool Correct = int.TryParse(val, out int value);
            if ( (Correct != true) || (value < 1) )
            {
                Console.WriteLine("Указано некорректное значение.");
                CheckValue();
            }
            return value;
        }

        static string[] PetsNames(int Count)
        {
            string[] Names = new string[Count];
            int i = 0;
            while (i < Count)
            {
                Console.WriteLine("Укажите имя питомца, пожалуйста.");
                Names[i] = Console.ReadLine();
                i++;
            }
            return Names;
        }
        static string[] Colours(int Count)
        {
            string[] Clr = new string[Count];
            int i;
            for (i = 0;i<Count; i++)
            {
                Console.WriteLine("Укажите любимый цвет, пожалуйста.");
                
                Clr[i] = Console.ReadLine();
                                
            }
            return Clr;
        }
    }
}
