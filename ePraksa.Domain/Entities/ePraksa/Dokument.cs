using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class Dokument
{
    public int IdDokument { get; set; }
    public int IdProfil { get; set; }
    public string Naziv { get; set; } = null!;
    public string Putanja { get; set; } = null!;
    public DateTime DatumUpload { get; set; }

    public ProfilStudent ProfilStudent { get; set; } = null!;
}
