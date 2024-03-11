using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

[Table("server_service_join", Schema = "mw_repo")]
public partial class ServerServiceJoin
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("server_ip")]
    [StringLength(55)]
    public string ServerIp { get; set; } = null!;

    [Column("service_name")]
    [StringLength(255)]
    public string ServiceName { get; set; } = null!;

    /*
    [ForeignKey("ServerIp")]
    [InverseProperty("ServerServiceJoins")]
    public virtual Server ServerIpNavigation { get; set; } = null!;

    [ForeignKey("ServiceName")]
    [InverseProperty("ServerServiceJoins")]
    public virtual Service ServiceNameNavigation { get; set; } = null!;
    */
}
