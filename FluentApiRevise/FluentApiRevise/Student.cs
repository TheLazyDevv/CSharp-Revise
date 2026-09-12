using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int GroupId { get; set; } // ForeignKey
    public virtual Group Group { get; set; } // Navigation property
}