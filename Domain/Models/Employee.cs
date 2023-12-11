namespace Domain.Models;

public class Employee
{
    public int id { get; set;}
    public string first_name { get; set; } = null!;

    public string last_name { get; set; } = null!;
    public int age { get; set; }
    public int salary { get; set; }

}

