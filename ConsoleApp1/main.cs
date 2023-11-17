class Program
{
    static void Main()
    {
        Mammal lion = new Mammal(1, "Leo", "Lion", 5, 50);
        Reptile snake = new Reptile(2, "Sly", "Snake", 2, true);
        Veterinarian vet = new Veterinarian(3, "Dr.", "Smith", "Veterinarian", "Wildlife");
        Security securityOfficer = new Security(4, "John", "Doe", "Security", "Level 2");

        Console.WriteLine("Animal Test:");
        lion.Eat();
        lion.Move();
        lion.Run();

        snake.Eat();
        snake.Move();
        snake.Crawl();

        Console.WriteLine("\nEmployee Test:");
        vet.Work();
        vet.Report();
        vet.TreatAnimal(lion);

        Console.WriteLine("\nSecurity Test:");
        securityOfficer.Work();
        securityOfficer.Report();
        securityOfficer.Patrol();

    }
}
