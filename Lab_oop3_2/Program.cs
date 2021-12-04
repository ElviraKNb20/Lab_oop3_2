using System;

namespace Lab_oop3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var iv = new Worker(25, "Iван", 1000);
            var va = new Worker(26, "Вася", 2000);
            Console.WriteLine("Iм'я: " + iv.getName + ", Вiк: " + iv.getAge + ", Зарплата: " + iv.getSalary);
            Console.WriteLine("Iм'я: " + va.getName + ", Вiк: " + va.getAge + ", Зарплата: " + va.getSalary);
            Console.WriteLine("Сумa зарплат - " + (iv.getSalary + va.getSalary));

            var pe = new Student(18, "Микола", 1990, 2);
            Console.Write("Студент: " + pe.getName + ", Вiк: " + pe.getAge);
            Console.WriteLine(", Стипендiя: " + pe.getStipend + ", Курс: " + pe.getCourse);

            var ev = new Driver(40, "Дмитро", 4000, 15, "А");
            Console.Write("Iм'я: " + ev.getName + ", Вiк: " + ev.getAge + ", Зарплата: " + ev.getSalary);
            Console.WriteLine(", Водiйський стаж: " + ev.getCategory + ", Категорiя водiння: " + ev.getExperience);
        }
    }
    class User
    {
        protected string name;
        protected int age;
        public string setName
        {
            set { name = value; }
        }
        public string getName
        {
            get { return name; }
        }
        public int setAge
        {
            set { age = value; }
        }
        public int getAge
        {
            get { return age; }
        }
        public User(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
    class Worker : User
    {
        private int salary;
        public int getSalary
        {
            get { return salary; }
        }
        public int setSalary
        {
            set { salary = value; }
        }
        public Worker(int age, string name, int salary) : base(age, name)
        {
            this.salary = salary;
        }
    }
    class Student : User
    {
        private int scholarship;
        private int course;
        public int getStipend
        {
            get { return scholarship; }
        }
        public int getCourse
        {
            get { return course; }
        }
        public Student(int age, string name, int scholarship, int course) : base(age, name)
        {
            this.scholarship = scholarship;
            this.course = course;
        }
    }
    class Driver : Worker
    {
        private int DrivingExperience;
        private string category;
        public int getCategory
        {
            get { return DrivingExperience; }
        }
        public string getExperience
        {
            get { return category; }
        }
        public Driver(int age, string name, int salary, int DrivingExperience, string category) : base(age, name, salary)
        {
            this.DrivingExperience = DrivingExperience;
            this.category = category;
        }
    }
}
