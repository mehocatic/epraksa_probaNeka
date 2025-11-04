using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Application.Modules.ProfilStudent.DTOs;

public class UpdateProfilStudentRequest
{
    public int IdProfil { get; set; }        
    public string Ime { get; set; } = default!;
    public string Prezime { get; set; } = default!;
    public DateTime? DatumRodjenja { get; set; }
    public string? Fakultet { get; set; }
    public int? IdGrad { get; set; }
}
