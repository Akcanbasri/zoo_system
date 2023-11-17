public class Employee
{
    private int id;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }

    public Employee(int id, string firstName, string lastName, string position)
    {
        this.id = id;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
    }

    public virtual void Work()
    {
        Console.WriteLine($"{FirstName} {LastName} is working as a {Position}.");
    }

    public virtual void Report()
    {
        Console.WriteLine($"{FirstName} {LastName} is reporting as a {Position}.");
    }
}

public class Veterinarian : Employee
{
    private int id;

    public string Specialization { get; set; }

    public Veterinarian(int id, string firstName, string lastName, string position, string specialization)
        : base(id, firstName, lastName, position)
    {
        this.id = id;
        Specialization = specialization;
    }

    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"{FirstName} {LastName} is treating {animal.Name}.");
    }

    public override void Work()
    {
        Console.WriteLine($"{FirstName} {LastName} is working as a {Specialization} veterinarian.");
    }

    public override void Report()
    {
        Console.WriteLine($"{FirstName} {LastName} is reporting as a {Specialization} veterinarian.");
    }
}

public class Security : Employee
{
    private int id;

    public string AccessLevel { get; set; }

    public Security(int id, string firstName, string lastName, string position, string accessLevel)
        : base(id, firstName, lastName, position)
    {
        this.id = id;
        AccessLevel = accessLevel;
    }

    public void Patrol()
    {
        Console.WriteLine($"{FirstName} {LastName} is patrolling with access level {AccessLevel}.");
    }

    public override void Work()
    {
        Console.WriteLine($"{FirstName} {LastName} is working as a security officer with access level {AccessLevel}.");
    }

    public override void Report()
    {
        Console.WriteLine($"{FirstName} {LastName} is reporting as a security officer with access level {AccessLevel}.");
    }
}
