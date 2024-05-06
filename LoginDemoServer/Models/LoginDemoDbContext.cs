using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoginDemoServer.Models;

public partial class LoginDemoDbContext : DbContext
{
    public LoginDemoDbContext()
    {
    }

    public LoginDemoDbContext(DbContextOptions<LoginDemoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB;Initial Catalog=LoginDemoDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasOne(d => d.EmailNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grade__Email__37A5467C");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__Users__A9D10535E38DC7DB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
