using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

[Table("services", Schema = "mw_repo")]
public partial class Service
{
    [Key]
    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("type")]
    [StringLength(255)]
    public string? Type { get; set; }

    [Column("ip")]
    [StringLength(255)]
    public string? Ip { get; set; }

    [Column("port")]
    public int? Port { get; set; }

    [Column("protocol")]
    [StringLength(255)]
    public string? Protocol { get; set; }

    [Column("port_type")]
    [StringLength(255)]
    public string? PortType { get; set; }

    [Column("uri")]
    [StringLength(255)]
    public string? Uri { get; set; }

    [Column("tls_enabled")]
    public bool? TlsEnabled { get; set; }

    [Column("certificate")]
    public string? Certificate { get; set; }

    [Column("admin_user")]
    [StringLength(255)]
    public string? AdminUser { get; set; }

    [Column("lifecycle")]
    [StringLength(255)]
    public string? Lifecycle { get; set; }

    [Column("system")]
    [StringLength(255)]
    public string? System { get; set; }

    [Column("admin_password")]
    [StringLength(255)]
    public string? AdminPassword { get; set; }
    /*
    [InverseProperty("ServiceNameNavigation")]
    public virtual ICollection<ServerServiceJoin> ServerServiceJoins { get; set; } = new List<ServerServiceJoin>();
    */
}
