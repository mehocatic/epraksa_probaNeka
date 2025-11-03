using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class Notifikacija
{
    public int IdNotifikacija { get; set; }
    public int IdKorisnik { get; set; }
    public string Sadrzaj { get; set; } = null!;
    public bool Procitano { get; set; }
    public DateTime Datum { get; set; }

    public Korisnik Korisnik { get; set; } = null!;
}
