using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Desktop
{
    internal class Session
    {
        public static int UserId { get; set; }
        public static string Peran { get; set; } = string.Empty;   // Role (e.g. "mahasiswa", "dosen", "admin-prodi")
        public static string Prodi { get; set; } = string.Empty;   // Prodi name or id (string)
    }

}
