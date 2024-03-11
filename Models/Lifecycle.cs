using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

[Table("lifecycles", Schema = "mw_repo")]
public partial class Lifecycle
{
    [Key]
    [Column("type")]
    [StringLength(255)]
    public string Type { get; set; } = null!;
}
