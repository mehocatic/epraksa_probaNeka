using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class Review
{
    public int IdReview { get; set; }
    public int IdStudentPraksa { get; set; }
    public int Ocjena { get; set; } // 1 - 5
    public string? Komentar { get; set; }
    public DateTime Datum { get; set; }

    public StudentPraksa StudentPraksa { get; set; } = null!;
}
