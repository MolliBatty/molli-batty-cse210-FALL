abstract class Person
{
    private string _firstName;
    private string _lastname;
    private int _age;
    private double _weight;

    public Person(string firstName, string lastName, int age, double weight)
    {
        _firstName = firstName;
        _lastname = lastName;
        _age = age;
        _weight = weight;
    }
    public virtual string GetPersonInformation()
    {
        return $"{_firstName} {_lastname} is {_age} years old and weighs {_weight}";
    }

    public abstract double GetSalary();
    
}