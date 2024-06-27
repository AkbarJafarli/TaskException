namespace TaskException
{
    public class Employee:IPerson
    {
        private static int nextId = 1;
        public string Name { get;}
        public int Age { get;}
        public int Id { get;}
        public decimal Salary { get;}
        public Employee (string name, int age,decimal salary)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Ad bos ola bilmez...");
            }
            if (age <= 0)
            {
                throw new ArgumentException("Yas 0 dan boyuk olmalidir...");
            }
            if (salary <= 0)
            {
                throw new ArgumentException("Maas 0 dan boyuk olmalidir");
            }
            Name = name;
            Age = age;
            Salary = salary;
            Id = nextId++;
        }
        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary:C}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
