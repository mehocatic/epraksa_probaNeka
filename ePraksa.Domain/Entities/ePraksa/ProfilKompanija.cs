using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class ProfilKompanija
{
    public int IdProfil { get; set; }
    public int IdKorisnik { get; set; }
    public string Naziv { get; set; } = null!;
    public string? Opis { get; set; }
    public string? WebStranica { get; set; }
    public int? IdGrad { get; set; }

    public Korisnik Korisnik { get; set; } = null!;
    public Grad? Grad { get; set; }

    public ICollection<Praksa> Prakse { get; set; } = new List<Praksa>();
}
