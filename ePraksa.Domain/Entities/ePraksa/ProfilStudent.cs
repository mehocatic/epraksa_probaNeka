

namespace ePraksa.Domain.Entities.EPraksa;


public class ProfilStudent
{
    public int IdProfil { get; set; }
    public int IdKorisnik { get; set; }
    public string Ime { get; set; } = null!;
    public string Prezime { get; set; } = null!;
    public DateTime? DatumRodjenja { get; set; }
    public string? Fakultet { get; set; }
    public int? IdGrad { get; set; }

    public Korisnik Korisnik { get; set; } = null!;
    public Grad? Grad { get; set; }

    public ICollection<StudentObrazovanje> Obrazovanja { get; set; } = new List<StudentObrazovanje>();
    public ICollection<StudentTehnologija> Tehnologije { get; set; } = new List<StudentTehnologija>();
    public ICollection<Dokument> Dokumenti { get; set; } = new List<Dokument>();
    public ICollection<StudentPraksa> PrijaveNaPrakse { get; set; } = new List<StudentPraksa>();
    public ICollection<FavoritPraksa> Favoriti { get; set; } = new List<FavoritPraksa>();
}
