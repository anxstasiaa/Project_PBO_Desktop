namespace Project_PBO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InisialisasiAwal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KelasKuliahs",
                c => new
                    {
                        KodeKelas = c.String(nullable: false, maxLength: 128),
                        KodeMK = c.String(maxLength: 128),
                        IDProdi = c.String(),
                        IDSemester = c.String(),
                        Ruangan = c.String(),
                        NamaKelas = c.String(),
                        JumlahPeserta = c.Int(nullable: false),
                        KapasitasKelas = c.Int(nullable: false),
                        DosenPengampu = c.String(),
                    })
                .PrimaryKey(t => t.KodeKelas)
                .ForeignKey("dbo.MataKuliahs", t => t.KodeMK)
                .Index(t => t.KodeMK);
            
            CreateTable(
                "dbo.MataKuliahs",
                c => new
                    {
                        KodeMK = c.String(nullable: false, maxLength: 128),
                        NamaMK = c.String(),
                        SKS = c.Int(nullable: false),
                        IDProdi = c.String(),
                        Semester = c.Int(nullable: false),
                        DosenPengampu = c.String(),
                    })
                .PrimaryKey(t => t.KodeMK);
            
            CreateTable(
                "dbo.Mahasiswas",
                c => new
                    {
                        NIM = c.String(nullable: false, maxLength: 128),
                        NamaMhs = c.String(),
                        AlamatMhs = c.String(),
                        IDProdi = c.String(),
                        Angkatan = c.Int(nullable: false),
                        SemesterAktif = c.String(),
                        TanggalLahir = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NIM);
            
            CreateTable(
                "dbo.Nilais",
                c => new
                    {
                        NIM = c.String(nullable: false, maxLength: 128),
                        KodeMK = c.String(nullable: false, maxLength: 128),
                        IDSemester = c.String(nullable: false, maxLength: 128),
                        KodeKelas = c.String(),
                        IDProdi = c.String(),
                        NamaMK = c.String(),
                        SKS = c.Int(nullable: false),
                        NilaiTugas = c.Double(nullable: false),
                        NilaiUTS = c.Double(nullable: false),
                        NilaiUAS = c.Double(nullable: false),
                        NilaiSoftSkill = c.Double(nullable: false),
                        NilaiAkhir = c.Double(nullable: false),
                        HurufMutu = c.String(),
                        AngkaMutu = c.Double(),
                    })
                .PrimaryKey(t => new { t.NIM, t.KodeMK, t.IDSemester });
            
            CreateTable(
                "dbo.Prodis",
                c => new
                    {
                        IDProdi = c.String(nullable: false, maxLength: 128),
                        NamaProdi = c.String(),
                        AliasProdi = c.String(),
                    })
                .PrimaryKey(t => t.IDProdi);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        IDSemester = c.String(nullable: false, maxLength: 128),
                        namaSemester = c.String(),
                    })
                .PrimaryKey(t => t.IDSemester);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KelasKuliahs", "KodeMK", "dbo.MataKuliahs");
            DropIndex("dbo.KelasKuliahs", new[] { "KodeMK" });
            DropTable("dbo.Semesters");
            DropTable("dbo.Prodis");
            DropTable("dbo.Nilais");
            DropTable("dbo.Mahasiswas");
            DropTable("dbo.MataKuliahs");
            DropTable("dbo.KelasKuliahs");
        }
    }
}
