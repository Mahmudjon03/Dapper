using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Students
{
    [Key]
    public int Id { get; set; }
    public string first_name { get; set; } = null!;
    public string last_name { get; set; } = null!;
    public string phone { get; set; } = null!;
}

