using System;

namespace classes_5
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private DateTime registerDate;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.firstName = name;
            this.lastName = surname;
            this.age = age;
            registerDate = DateTime.Now;
        }
        public override string ToString()
        {
            return "Login: " + login + " \nname: " + firstName + "\nsurname: " + lastName + "\nage: " + age + " \nDate of reistration: " + registerDate.ToString();
        }
    }
    class Program
    {
        static string Input(string variableName)
        {
            Console.Write("Enter your " + variableName + ": ");
            return Console.ReadLine();

        }
        static void Main(string[] args)
        {
            {
                string login = Input("login");
                string firstName = Input("first name");
                string lastName = Input("last name");
                int age = Convert.ToInt32(Input("age"));
                Console.Clear();

                User u = new User(login, firstName, lastName, age);
                Console.WriteLine(u.ToString());
                Console.ReadKey();
            }
        }
    }
}
