class Program
{
    public static void Main()
    {
        Person myperson = new Person("Molli", "Batty", 22, 115.21);
        Console.WriteLine(myperson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payen", 45, 279, "Knife");
        Console.WriteLine(myDoctor.GetPersonInformation());

        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}
