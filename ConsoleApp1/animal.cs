public class Animal
{
    private int id;

    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }

    public Animal(int id, string name, string species, int age)
    {
        this.id = id;
        Name = name;
        Species = species;
        Age = age;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }
}

public class Mammal : Animal
{
    private int id;

    public int Speed { get; set; }

    public Mammal(int id, string name, string species, int age, int speed)
        : base(id, name, species, age)
    {
        this.id = id;
        Speed = speed;
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating like a mammal.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is moving like a mammal at speed {Speed}.");
    }

    public void Run()
    {
        Console.WriteLine($"{Name} is running at speed {Speed}.");
    }
}

public class Reptile : Animal
{
    private int id;

    public bool IsColdBlooded { get; set; }

    public Reptile(int id, string name, string species, int age, bool isColdBlooded)
        : base(id, name, species, age)
    {
        this.id = id;
        IsColdBlooded = isColdBlooded;
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating like a reptile.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is moving like a reptile.");
    }

    public void Crawl()
    {
        Console.WriteLine($"{Name} is crawling.");
    }
}
