using System;
using System.Collections.Generic;

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public byte[] NoPolisi { get; set; }
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        public byte[] Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
