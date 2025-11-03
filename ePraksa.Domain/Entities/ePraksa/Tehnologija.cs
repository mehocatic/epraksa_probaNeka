using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class Tehnologija
{
    public int IdTehnologija { get; set; }
    public string Naziv { get; set; } = null!;

    public ICollection<StudentTehnologija> Studenti { get; set; } = new List<StudentTehnologija>();
    public ICollection<PraksaTehnologija> Prakse { get; set; } = new List<PraksaTehnologija>();
}
