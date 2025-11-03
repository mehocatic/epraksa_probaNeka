using ePraksa.Domain.Entities.EPraksa;

public class Grad
{
    public int IdGrad { get; set; }
    public string Naziv { get; set; } = null!;

    public ICollection<ProfilStudent> ProfiliStudenta { get; set; } = new List<ProfilStudent>();
    public ICollection<ProfilKompanija> ProfiliKompanije { get; set; } = new List<ProfilKompanija>();
}
