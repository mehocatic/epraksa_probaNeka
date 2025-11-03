namespace ePraksa.Application.Modules.ProfilStudent.DTOs;

public class CreateProfilStudentRequest
{
    public int IdKorisnik { get; set; }
    public string Ime { get; set; } = default!;
    public string Prezime { get; set; } = default!;
    public DateTime? DatumRodjenja { get; set; }
    public string? Fakultet { get; set; }
    public int? IdGrad { get; set; }

    // (opcionalno u istom POST-u; možeš i kasnije posebnim endpointima)
    public List<int>? TehnologijeIds { get; set; }
    public List<ObrazovanjeItem>? Obrazovanja { get; set; }
    public List<DokumentItem>? Dokumenti { get; set; }

    public class ObrazovanjeItem
    {
        public string Institucija { get; set; } = default!;
        public string? Smjer { get; set; }
        public string? NivoStudija { get; set; }
        public int? GodinaUpisa { get; set; }
        public int? GodinaZavrsetka { get; set; }
    }

    public class DokumentItem
    {
        public string Naziv { get; set; } = default!;
        public string Putanja { get; set; } = default!;
    }
}
