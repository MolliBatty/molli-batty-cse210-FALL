class Employee
{
    private string _name;
    private int _id;
    private decimal _BaseSalary;

    public Employee(string name, int id, decimal BaseSalary)
    {
        _name = name;
        _id = id;
        _BaseSalary = BaseSalary;
    }

    public virtual decimal CalculatePay()
    {
        return _BaseSalary;
    }

    public void Describe()
    {
        Console.WriteLine($"{_name} (ID: {_id} earns ${CalculatePay()})");
    }
}