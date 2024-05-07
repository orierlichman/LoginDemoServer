using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LoginDemoServer.Models;

[Keyless]
[Table("Grade")]
public partial class Grade
{
    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(20)]
    public string SubjectName { get; set; } = null!;

    public int TestGrade { get; set; }

    [StringLength(100)]
    public string Email { get; set; } = null!;

    [ForeignKey("Email")]
    public virtual User? EmailNavigation { get; set; } = null!;
}
