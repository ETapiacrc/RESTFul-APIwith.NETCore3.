using System;
using System.Collections.Generic;
using BPark.infrastructure.Entities;
using Microsoft.EntityFrameworkCore;


namespace BPark.infrastructure.Data;

public partial class BparkContext : DbContext
{
    public BparkContext()
    {
    }

    public BparkContext(DbContextOptions<BparkContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=EDGARTR; Database=BPark; Trusted_Connection=True; TrustServerCertificate=True;");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }
    public DbSet<Post> Publicacion { get; set; }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
