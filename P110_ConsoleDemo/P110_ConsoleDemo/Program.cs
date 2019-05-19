using System;
using System.Text;
using PrimaryClasses;

namespace P110_ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetEmail("samir@code.az");

            person.father

            person.SetPassword("23@"); //samir23@123

            Console.WriteLine(person.CheckPassword("23@"));
        } 
    }

    public class Developer : Person
    {
        public string PasswordYoxla(string pass)
        {
            return HashPassword(pass);
        }
    }
}

