using TaskException;

try
{
    Department department = new Department("HR Department", 3);
    Employee emp1 = new Employee("Akbar Jafarli", 20, 17500);
    Employee emp2 = new Employee("Asiman Qasimzade", 22, 4000);
    Employee emp3 = new Employee("Leonardo DiCaprio", 25, 50000);

    department.AddEmployee(emp1);
    department.AddEmployee(emp2);
    department.AddEmployee(emp3);

    Console.WriteLine(department[0]);
    department[0] = new Employee("Akbar Jafarli", 20, 17500);
}
catch(Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}
