namespace TaskException
{
    public class Department
    {
        private readonly Employee[] employees;
        public string Name { get;}
        public int EmployeeLimit { get;}

        public Department(string name,int employeeLimit)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Department adi bos ola bilmez...");
            }
            if(employeeLimit <= 0)
            {
                throw new ArgumentException("Isci limiti 0 dan boyuk olmalidir");
            }
            Name = name;
            EmployeeLimit = employeeLimit;
            employees = new Employee[employeeLimit];
        }

        public void AddEmployee(Employee employee)
        {
            if(employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Null ola bilmez");
            }

            for(int i = 0; i < employees.Length; i++)
            {
                if(employees[i] == null)
                {
                    employees[i] = employee;
                    return;
                }
            }
            throw new CapacityLimitException($"{EmployeeLimit}-Bundan artiq isci elave etmek olmaz...");
        }

        public Employee this[int index]
        {
            get
            {
                if(index<0 || index >= employees.Length)
                {
                    throw new IndexOutOfRangeException("Index limiti kecib...");
                }
                return employees[index];
            }
            set
            {
                if(index<0 || index >= employees.Length)
                {
                    throw new IndexOutOfRangeException("Index limiti kecib...");
                }
                if(value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Null ola bilmez...");
                }
                employees[index] = value;
            }
        }

    }
}
