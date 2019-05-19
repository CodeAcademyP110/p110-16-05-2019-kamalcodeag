using System;

namespace PrimaryClasses
{
    public class Demo
    {
        void Show()
        {
            Person person = new Person();
            person.Fathername = "samir";
        }
    }

    class Dev : Person
    {
        string GetFatherName()
        {
            return Fathername;
        }
    }

    public class Person
    {
        public string Firstname;
        public string Lastname;
        protected internal string Fathername;

        //encapsulated email field - user can not set whatever he/she wants
        private string _email; //access modifier - əlçatanlıq dərəcəsi
        private string _password;

        public string GetEmail()
        {
            return _email;
        }

        public void SetEmail(string email)
        {
            //demo version for Perviz
            if (email.IndexOf("@") != -1)
            {
                _email = email;
                return;
            }

            throw new ArgumentException("Email is not valid");
        }

        public void SetPassword(string password)
        {
            _password = HashPassword(password);
        }

        protected string HashPassword(string p)
        {
            //demo hash
            return "samir" + p + "123";
        }

        public bool CheckPassword(string password)
        {
            return HashPassword(password) == _password;
        }
    }
}
