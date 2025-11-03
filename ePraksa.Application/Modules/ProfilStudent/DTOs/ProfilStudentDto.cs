namespace ePraksa.Application.Modules.ProfilStudent.DTOs;

public class ProfilStudentDto
{
    public int IdProfil { get; set; }
    public int IdKorisnik { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public DateTime? DatumRodjenja { get; set; }
    public string? Fakultet { get; set; }
    public int? IdGrad { get; set; }
    public string? GradNaziv { get; set; }

    public List<string> Tehnologije { get; set; } = new();
    public List<DokumentItem> Dokumenti { get; set; } = new();
    public List<ObrazovanjeItem> Obrazovanja { get; set; } = new();

    public class DokumentItem
    {
        public int IdDokument { get; set; }
        public string Naziv { get; set; }
    }

    public class ObrazovanjeItem
    {
        public int IdObrazovanje { get; set; }
        public string Institucija { get; set; } = default!;
        public string? Smjer { get; set; }
        public string? NivoStudija { get; set; }
        public int? GodinaUpisa { get; set; }      // ⬅ sada nullable
        public int? GodinaZavrsetka { get; set; }  // već OK
    }




}
