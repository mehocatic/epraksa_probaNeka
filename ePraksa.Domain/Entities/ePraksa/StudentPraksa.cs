using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class StudentPraksa
{
    public int IdStudentPraksa { get; set; }
    public int IdProfil { get; set; }
    public int IdPraksa { get; set; }
    public DateTime DatumPrijave { get; set; }
    public int? IdStatus { get; set; }
    public string? MotivacionoPismo { get; set; }

    public ProfilStudent ProfilStudent { get; set; } = null!;
    public Praksa Praksa { get; set; } = null!;
    public StatusPrijave? StatusPrijave { get; set; }
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
