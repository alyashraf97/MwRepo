using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

[Table("system", Schema = "mw_repo")]
public partial class Systems
{
    [Column("type")]
    [StringLength(255)]
    public string Type { get; set; } = null!;

    [Column("comment")]
    public string? Comment { get; set; }

    [Column("is_in_production")]
    public bool IsInProduction { get; set; }

    [Key]
    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("service_owner")]
    [StringLength(255)]
    public string? ServiceOwner { get; set; }

    [Column("shortname")]
    [StringLength(255)]
    public string? Shortname { get; set; }

    [Column("vendor")]
    [StringLength(255)]
    public string? Vendor { get; set; }

    [Column("product_name")]
    [StringLength(255)]
    public string? ProductName { get; set; }
    /*

    [InverseProperty("SystemNameNavigation")]
    public virtual ICollection<SystemServerJoin> SystemServerJoins { get; set; } = new List<SystemServerJoin>();
    */
}
