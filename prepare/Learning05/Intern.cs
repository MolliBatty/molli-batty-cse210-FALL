sealed class Intern : Employee
{
    private string _school;
    private decimal _Stipend;

    public Intern(string name, int id, decimal BaseSalary, string school, decimal Stipend)
        :base(name, id, BaseSalary)
    {
        _school = school;
        _Stipend = 200;
    }

    public override decimal CalculatePay()
    {
        return base.CalculatePay() + _Stipend;
    }
    
}