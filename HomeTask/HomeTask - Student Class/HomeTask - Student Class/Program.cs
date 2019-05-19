using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassesToBeUsed;

namespace HomeTask___Student_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Kamal = new Student("Kamal", "Guliyev", new DateTime (1994,09,03));
            //Console.Write($"{Kamal.Name} {Kamal.Surname}");
            //Kamal.SetUsername();
            Console.WriteLine(Kamal.GetUsername());
            Kamal.SetEmail("kamalguliyev06@gmail.com");
            Console.WriteLine(Kamal.ShortInfo());
            Console.WriteLine(Kamal.FullInfo());
            Console.ReadLine();


        }
    }

    class Student
    {
        public string Name; //Kamal
        public string Surname; //Guliyev
        private string Username; //kamalguliyev
        public DateTime BirthDate; //1994,09,03
        private string Email; //kamalguliyev06@gmail.com

        public Student(string name, string surname)
        {
            SetFullName(name, surname);
            SetUsername();

        }

        public Student(string name, string surname, DateTime birthdate) : this(name, surname)
        {
            SetBirthDate(birthdate);
        }

        public void SetFullName(string name, string surname)
        {
            if (name.Length >= 2 && surname.Length >= 2)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if ((int)name[i] >= 65 && (int)name[i] <= 122)
                    {
                        Name = name.Replace(" ", "");
                    }
                    else
                    {
                        Console.WriteLine("Please, add a name containing only letters (A-Z)");
                    }
                    break;
                }
                for (int i = 0; i < surname.Length; i++)
                {
                    if ((int)surname[i] >= 65 && (int)surname[i] <= 122)
                    {
                        Surname = surname.Replace(" ", "");
                    }
                    else
                    {
                        Console.WriteLine("Please, add a surname containing only letters (A-Z)");
                    }
                    break;
                }
            }
            else
            {
                Console.WriteLine("Please,add name and surname containing minimum 2 letters");
            }
        }

        public void SetUsername()
        {
            Username = $"{Name.Replace(" ", "").ToLower()}{Surname.Replace(" ", "").ToLower()}";
        }

        public string GetUsername()
        {
            return Username;
        }

        public void SetBirthDate(DateTime birthdate)
        {
            if (birthdate >= DateTime.Now)
            {
                Console.WriteLine("Please,set a valid birthdate");
                //return;
            }
            else
            {
                BirthDate = birthdate;
            }
        }

        public void SetEmail(string email)
        {
            if (email.Contains("@gmail.com"))
            {
                Email = email.Replace(" ", "");
            }
            else
            {
                Console.WriteLine("Please,enter an email ending with '@gmail.com'");
            }
        }

        public string GetEmail()
        {
            return Email;
        }

        public string ShortInfo()
        {
            return $"{Name} {Surname}";
        }

        public string FullInfo()
        {
            return $"Name: {Name}, Surname: {Surname}, Email: {Email}, Age: {DateTime.Now.Year - BirthDate.Year}";
        }
    }

    //class Student : Person
    //{
    //    //public string Name; //Kamal
    //    //public string Surname; //Guliyev
    //    private string Username; //kamalguliyev
    //    public DateTime BirthDate; //1994,09,03
    //    private string Email; //kamalguliyev06@gmail.com

    //    public Student(string name, string surname) :base(name,surname)
    //    {
    //        SetFullName(name, surname);
    //        SetUsername();

    //    }

    //    public Student(string name, string surname, DateTime birthdate) : this(name, surname)
    //    {
    //        SetBirthDate(birthdate);
    //    }

    //    public void SetFullName(string name, string surname)
    //    {
    //        if (name.Length >= 2 && surname.Length >= 2)
    //        {
    //            for (int i = 0; i < name.Length; i++)
    //            {
    //                if ((int)name[i] >= 65 && (int)name[i] <= 122)
    //                {
    //                    Name = name.Replace(" ", "");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Please, add a name containing only letters (A-Z)");
    //                }
    //                break;
    //            }
    //            for (int i = 0; i < surname.Length; i++)
    //            {
    //                if ((int)surname[i] >= 65 && (int)surname[i] <= 122)
    //                {
    //                    Surname = surname.Replace(" ", "");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Please, add a surname containing only letters (A-Z)");
    //                }
    //                break;
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Please,add name and surname containing minimum 2 letters");
    //        }
    //    }

    //    public void SetUsername()
    //    {
    //        Username = $"{Name.Replace(" ", "").ToLower()}{Surname.Replace(" ", "").ToLower()}";
    //    }

    //    public string GetUsername()
    //    {
    //        return Username;
    //    }

    //    public void SetBirthDate(DateTime birthdate)
    //    {
    //        if (birthdate >= DateTime.Now)
    //        {
    //            Console.WriteLine("Please,set a valid birthdate");
    //            //return;
    //        }
    //        else
    //        {
    //            BirthDate = birthdate;
    //        }
    //    }

    //    public void SetEmail(string email)
    //    {
    //        if (email.Contains("@gmail.com"))
    //        {
    //            Email = email.Replace(" ", "");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Please,enter an email ending with '@gmail.com'");
    //        }
    //    }

    //    public string GetEmail()
    //    {
    //        return Email;
    //    }

    //    public string ShortInfo()
    //    {
    //        return $"{Name} {Surname}";
    //    }

    //    public string FullInfo()
    //    {
    //        return $"Name: {Name}, Surname: {Surname}, Email: {Email}, Age: {DateTime.Now.Year - BirthDate.Year}";
    //    }
    //}
}
