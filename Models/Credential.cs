using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

[Table("credentials", Schema = "mw_repo")]
public partial class Credential
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("type")]
    [StringLength(255)]
    public string? Type { get; set; }

    [Column("server_ip")]
    [StringLength(255)]
    public string? ServerIp { get; set; }

    [Column("username")]
    [StringLength(255)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(255)]
    public string? Password { get; set; }

    [Column("service_uri")]
    public string? ServiceUri { get; set; }

    [Column("lifecycle")]
    [StringLength(255)]
    public string? Lifecycle { get; set; }

    [Column("system", TypeName = "character varying")]
    public string? System { get; set; }

    [Column("service_type")]
    [StringLength(255)]
    public string? ServiceType { get; set; }
}
