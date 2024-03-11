using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

[Table("operating_system", Schema = "mw_repo")]
public partial class Os
{
    [Key]
    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("vendor")]
    [StringLength(255)]
    public string? Vendor { get; set; }

    [Column("supported")]
    public bool? Supported { get; set; }
}
