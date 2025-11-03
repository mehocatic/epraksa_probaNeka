using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class StatusPrijave
{
    public int IdStatus { get; set; }
    public string Naziv { get; set; } = null!;

    public ICollection<StudentPraksa> PrijaveStudenata { get; set; } = new List<StudentPraksa>();
}
