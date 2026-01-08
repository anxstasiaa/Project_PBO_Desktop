using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Project_PBO_Desktop
{
    public class SiakadContext : DbContext
    {

        public DbSet<FormMahasiswa> TblMahasiswa { get; set; }
        public DbSet<Prodi> TblProdi     { get; set; }
        public DbSet<FormKelolaMK> TblMataKuliah { get; set; }
        public DbSet<FormKelolaSmt> TblSemester { get; set; }
        public DbSet<FormKelolaKK> TblKelasKuliah { get; set; }
        public DbSet<FormInputNilai> TblNilai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormMahasiswa>().HasKey(m => m.NIM);
            modelBuilder.Entity<FormKelolaMK>().HasKey(mk => mk.KodeMK);
            modelBuilder.Entity<Prodi>().HasKey(p => p.IDProdi);
            modelBuilder.Entity<FormKelolaSmt>().HasKey(s => s.IDSemester);
            modelBuilder.Entity<FormKelolaKK>().HasKey(kk => kk.KodeKelas);

            modelBuilder.Entity<FormInputNilai>().HasKey(n => new { n.NIM, n.KodeMK, n.IDSemester });

            base.OnModelCreating(modelBuilder);
        }
    }
}
