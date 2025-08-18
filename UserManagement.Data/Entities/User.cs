using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Models;

public class User
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Forename { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public string Email { get; set; } = default!;

    /// <summary>
    /// Date of birth property uses DateTime owning to a lack of a 'Date' property in C#
    /// Implementing a new struct for this seems like a waste of time, so time properties of this struct will simply be left unused
    /// </summary>
    public DateTime DateOfBirth { get; set; } = default!;
    public bool IsActive { get; set; }
}
