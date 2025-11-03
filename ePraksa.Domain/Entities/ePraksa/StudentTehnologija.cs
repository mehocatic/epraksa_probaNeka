using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ePraksa.Domain.Entities.EPraksa;

public class StudentTehnologija
{
    public int IdProfil { get; set; }
    public int IdTehnologija { get; set; }

    public ProfilStudent ProfilStudent { get; set; } = null!;
    public Tehnologija Tehnologija { get; set; } = null!;
}
