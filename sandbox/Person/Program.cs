class Program
{
    public static void DisplayPersonINfo(Person person)
    {
        if(person is Doctor doctor)
            {
                Console.WriteLine(doctor.GetDoctorInformation());
            }
            else if (person is Police p)
            {
                Console.WriteLine(p.GetPolicerInformation());
            }
            else
            {
                Console.WriteLine(person.GetPersonInformation());
            }
    }
    public static void Main()
    {
        Person myPerson = new Person("Molli", "Batty", 22, 115.21);
        // Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payen", 45, 279, "Knife");
        // Console.WriteLine(myDoctor.GetPersonInformation());

        // Console.WriteLine(myDoctor.GetDoctorInformation());

        Police myPolice = new Police("Gary", "Goodman", 61, 181, "Guns");
        // Console.WriteLine(myPolice.GetPolicerInformation());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            DisplayPersonINfo(person);
            
            // if(person is Doctor doctor)
            // {
            //     Console.WriteLine(doctor.GetDoctorInformation());
            // }
            // else
            // {
            //     Console.WriteLine(person.GetPersonInformation());
            // }
        }
    }
}
