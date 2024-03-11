using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

[Table("servers", Schema = "mw_repo")]
public partial class Server
{
    [Key]
    [Column("ip_address")]
    [StringLength(55)]
    public string IpAddress { get; set; } = null!;

    [Column("hostname")]
    [StringLength(255)]
    public string? Hostname { get; set; }

    [Column("full_name")]
    [StringLength(255)]
    public string? FullName { get; set; }

    [Column("system")]
    [StringLength(255)]
    public string? System { get; set; }

    [Column("os")]
    [StringLength(255)]
    public string? Os { get; set; }

    [Column("os_version")]
    [StringLength(255)]
    public string? OsVersion { get; set; }

    [Column("hardware_model")]
    [StringLength(255)]
    public string? HardwareModel { get; set; }

    [Column("lifecycle")]
    [StringLength(255)]
    public string? Lifecycle { get; set; }

    [Column("application")]
    [StringLength(255)]
    public string? Application { get; set; }

    [Column("is_virtual")]
    public bool? IsVirtual { get; set; }

    [Column("cores")]
    public int? Cores { get; set; }

    [Column("memory")]
    public long? Memory { get; set; }

    [Column("mac_address")]
    [StringLength(255)]
    public string? MacAddress { get; set; }

    [Column("hypervisor")]
    [StringLength(255)]
    public string? Hypervisor { get; set; }

    [Column("location")]
    [StringLength(255)]
    public string? Location { get; set; }

    [Column("comment")]
    public string? Comment { get; set; }

    [Column("backend")]
    [StringLength(255)]
    public string? Backend { get; set; }

    [Column("dedicated_admin")]
    [StringLength(255)]
    public string? DedicatedAdmin { get; set; }
    /*

    [InverseProperty("ServerIpNavigation")]
    public virtual ICollection<ServerServiceJoin> ServerServiceJoins { get; set; } = new List<ServerServiceJoin>();

    [InverseProperty("ServerIpNavigation")]
    public virtual ICollection<SystemServerJoin> SystemServerJoins { get; set; } = new List<SystemServerJoin>();
    */
}
