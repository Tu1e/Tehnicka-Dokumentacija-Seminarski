using System.ComponentModel;

namespace Common.Domain
{
    public class Inzenjer
    {
        [DisplayName("ID inženjera")]
        public int IdInzenjer { get; set; }

        [DisplayName("Ime")]
        public string Ime { get; set; }

        [DisplayName("Prezime")]
        public string Prezime { get; set; }

        [DisplayName("Korisničko ime")]
        public string Username { get; set; }

        [DisplayName("Šifra")]
        public string Password { get; set; }

        [DisplayName("Licenca")]
        public string Licenca { get; set; }

        public string ImePrezime => $"{Ime} {Prezime}";
    }
}
