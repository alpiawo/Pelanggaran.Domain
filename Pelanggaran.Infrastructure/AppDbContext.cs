using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pelanggaran.Domain;

namespace Pelanggaran.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Jurusan> jurusan { get; set; }
        public DbSet<Kelas> Kelas { get; set; }
        public DbSet<Peraturan> Peraturan { get; set; }
        public DbSet<Guru> guru { get; set; }
        public DbSet<Siswa> Siswa { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jurusan>().HasKey(j => j.Id);
            modelBuilder.Entity<Kelas>().HasKey(k => k.Id);
            modelBuilder.Entity<Peraturan>().HasKey(p => p.Id);
            modelBuilder.Entity<Guru>().HasKey(g => g.Id);
            modelBuilder.Entity<Siswa>().HasKey(s => s.Id);

            modelBuilder.Entity<Kelas>()
                .HasOne<Jurusan>()
                .WithMany()
                .HasForeignKey(k => k.IdJurusan);

            modelBuilder.Entity<Siswa>()
                .HasOne<Kelas>()
                .WithMany()
                .HasForeignKey(s => s.KelasId);

            modelBuilder.Entity<Siswa>()
                .HasOne<Guru>()
                .WithMany()
                .HasForeignKey(s => s.GuruPencatatId);
        }
    }
}

