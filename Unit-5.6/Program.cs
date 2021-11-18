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


            var UserData = GetUserData();


        }

        public void GetUserData()
        {
            Console.WriteLine("Укажите свое имя, пожалуйста.");
            string Name = Console.ReadLine();
            Console.WriteLine("Укажите свою фамилию, пожалуйста.");
            string SName = Console.ReadLine();
            Console.WriteLine("Укажите свой возраст, пожалуйста.");
            
            
            int.TryParse(Console.ReadLine(), out int Age);



        }
        static bool AskPets()
        {
            bool Correct = false;
            while (Correct!=true)
            {
                Console.WriteLine("Есть ли у Вас домашние животные? \n Y - ДА, N - Нет");
                string PetExist = Console.ReadLine();

                if (PetExist == "Y")
                {
                    Console.WriteLine("Солько их?");



                    Correct = true;
                }
                if (PetExist == "N")
                {
                    Correct = true;
                }
            }
            






        }
        static string[] PetsNames(int Count)
        {

        }

    }
}
