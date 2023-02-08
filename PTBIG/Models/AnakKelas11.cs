using System.ComponentModel.DataAnnotations;

namespace PTBIG.Models
{
    public class AnakKelas11
    {
        [Key]
        public int ID { get; set; }
        public string Nama { get; set; }
        public int Kelas { get; set; }
        public int Umur { get; set;}
        public int Tinggi { get; set; }
        public int Berat { get; set; }
    }
}
