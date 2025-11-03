using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class StudentObrazovanje
{
    public int IdObrazovanje { get; set; }
    public int IdProfil { get; set; }
    public string Institucija { get; set; } = null!;
    public string? Smjer { get; set; }
    public string? NivoStudija { get; set; }
    public int? GodinaUpisa { get; set; }
    public int? GodinaZavrsetka { get; set; }

    public ProfilStudent ProfilStudent { get; set; } = null!;
}
