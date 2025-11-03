using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class Praksa
{
    public int IdPraksa { get; set; }
    public int IdKompanija { get; set; }
    public string Naziv { get; set; } = null!;
    public string? Opis { get; set; }
    public int? TrajanjeMjeseci { get; set; }
    public string? Lokacija { get; set; }
    public DateTime DatumObjave { get; set; }
    public DateTime? DatumZavrsetka { get; set; }
    public bool Aktivna { get; set; }

    public ProfilKompanija Kompanija { get; set; } = null!;
    public ICollection<PraksaTehnologija> Tehnologije { get; set; } = new List<PraksaTehnologija>();
    public ICollection<StudentPraksa> PrijaveStudenata { get; set; } = new List<StudentPraksa>();
    public ICollection<FavoritPraksa> Favoriti { get; set; } = new List<FavoritPraksa>();
}
