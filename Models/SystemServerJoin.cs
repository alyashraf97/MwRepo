using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

[Table("system_server_join", Schema = "mw_repo")]
public partial class SystemServerJoin
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("server_ip")]
    [StringLength(55)]
    public string ServerIp { get; set; } = null!;

    [Column("system_name")]
    [StringLength(255)]
    public string SystemName { get; set; } = null!;

    /*
    [ForeignKey("ServerIp")]
    [InverseProperty("SystemServerJoins")]
    public virtual Server ServerIpNavigation { get; set; } = null!;

    [ForeignKey("SystemName")]
    [InverseProperty("SystemServerJoins")]
    public virtual Systems SystemNameNavigation { get; set; } = null!;
    */
}
