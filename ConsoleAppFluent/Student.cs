namespace ConsoleAppFluent;

public record Student
{
    public static Student New(string name) => new(name, "");
    private Student(string name, string age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; }
    public string Age { get; private set; }

    public Student WithAge(string age)
    {
        return this with
        {
            Age = age
        };
    }
}