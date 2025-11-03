using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class PraksaTehnologija
{
    public int IdPraksa { get; set; }
    public int IdTehnologija { get; set; }

    public Praksa Praksa { get; set; } = null!;
    public Tehnologija Tehnologija { get; set; } = null!;
}
