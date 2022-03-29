using Department_Console_App.Interfaces;

namespace Department_Console_App.Models
{
    public class Employee : IPerson
    {

        private static int _id;
        private  int _age;
        private int _salary;
        
        public string Name { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if (value <= 150 && value >= 0)
                {
                    _age = value;
                }
            }
        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
            }
        }

        public int Id { get; set; }
        
        
        static Employee()
        {
            _id = 0;
        }

        private Employee()
        {
            Id = ++_id;
        }

        public Employee(string name, int age, int salary):this()
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string ShowInfo()
        {
            return $"\nId: {Id.ToString()}\nName: {Name}\nAge: {Age.ToString()}\nSalary: {Salary.ToString()} 💵";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}