class Manager : Employee
{
    private decimal _bonus;

    public Manager(string name, int id, decimal BaseSalary, decimal bonus) 
        :base(name, id, BaseSalary)
    {
        _bonus = bonus;
    }

    public override decimal CalculatePay()
    {
        return base.CalculatePay() + _bonus;
    }
}