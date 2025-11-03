using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePraksa.Domain.Entities.EPraksa;

public class Korisnik
{
    public int IdKorisnik { get; set; }
    public string Email { get; set; } = null!;
    public string Lozinka { get; set; } = null!;
    public DateTime DatumRegistracije { get; set; }
    public string TipKorisnika { get; set; } = null!; // 'student', 'kompanija', 'admin'
    public bool Aktivna { get; set; }

    public ICollection<ProfilStudent> ProfiliStudenta { get; set; } = new List<ProfilStudent>();
    public ICollection<ProfilKompanija> ProfiliKompanije { get; set; } = new List<ProfilKompanija>();
    public ICollection<ChatPoruka> PoslanePoruke { get; set; } = new List<ChatPoruka>();
    public ICollection<ChatPoruka> PrimljenePoruke { get; set; } = new List<ChatPoruka>();
    public ICollection<Notifikacija> Notifikacije { get; set; } = new List<Notifikacija>();
}

