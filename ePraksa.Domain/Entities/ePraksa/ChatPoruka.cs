using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class ChatPoruka
{
    public int IdPoruka { get; set; }
    public int IdPosiljalac { get; set; }
    public int IdPrimalac { get; set; }
    public string Sadrzaj { get; set; } = null!;
    public DateTime DatumSlanja { get; set; }
    public bool Procitana { get; set; }

    public Korisnik Posiljalac { get; set; } = null!;
    public Korisnik Primalac { get; set; } = null!;
}
