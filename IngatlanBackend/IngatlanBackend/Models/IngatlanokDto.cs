namespace IngatlanBackend.Models
{
    public class IngatlanokDto
    {
        public int Kategoria { get; set; }
        public string? Leiras { get; set; }

        public DateTime? HirdetesDatuma { get; set; }

        public bool Tehermentes { get; set; }

        public int Ar { get; set; }

        public string? KepUrl { get; set; }
    }
}