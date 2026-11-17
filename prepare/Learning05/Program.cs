public class Program
{
    public static void Main()
    {
        Employee[] employees =
        {
            new Employee("Alice", 101, 3000),
            new Manager("Bob", 102, 5000, 1500),
            new Intern("Cara", 103, 1200, "BYU-Idaho")
        };

        foreach (Employee e in employees)
        {
            e.Describe();
        }
    }
}