using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MwRepo.Models;

public partial class MwDbContext : DbContext
{
    public MwDbContext()
    {
    }

    public MwDbContext(DbContextOptions<MwDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Credential> Credentials { get; set; }

    public virtual DbSet<Lifecycle> Lifecycles { get; set; }

    public virtual DbSet<Os> OperatingSystems { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    //public virtual DbSet<ServerServiceJoin> ServerServiceJoins { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Systems> Systems { get; set; }

    //public virtual DbSet<SystemServerJoin> SystemServerJoins { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Credential>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("credentials_pk");
        });

        modelBuilder.Entity<Lifecycle>(entity =>
        {
            entity.HasKey(e => e.Type).HasName("lifecycles_pk");
        });

        modelBuilder.Entity<Os>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("operating_system_pk");
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.IpAddress).HasName("servers_pk");
        });

        /*
        modelBuilder.Entity<ServerServiceJoin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("server_service_join_pk");

            entity.HasOne(d => d.ServerIpNavigation).WithMany(p => p.ServerServiceJoins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("server_service_join_servers_fk");

            entity.HasOne(d => d.ServiceNameNavigation).WithMany(p => p.ServerServiceJoins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("server_service_join_services_fk");
        });
        */

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("services_pk");
        });

        modelBuilder.Entity<Systems>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("system_pk");
        });
        /*

        modelBuilder.Entity<SystemServerJoin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("system_server_join_pk");

            entity.HasOne(d => d.ServerIpNavigation).WithMany(p => p.SystemServerJoins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("system_server_join_servers_fk");

            entity.HasOne(d => d.SystemNameNavigation).WithMany(p => p.SystemServerJoins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("system_server_join_system_fk");
        });
        */

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
