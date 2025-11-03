using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class FavoritPraksa
{
    public int IdProfil { get; set; }
    public int IdPraksa { get; set; }
    public DateTime DatumDodavanja { get; set; }

    public ProfilStudent ProfilStudent { get; set; } = null!;
    public Praksa Praksa { get; set; } = null!;
}

