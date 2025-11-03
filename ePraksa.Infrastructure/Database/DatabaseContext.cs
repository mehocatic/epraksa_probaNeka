using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ePraksa.Application.Abstractions;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database;

public class DatabaseContext : DbContext, IAppDbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<Korisnik> Korisnici => Set<Korisnik>();
    public DbSet<Grad> Gradovi => Set<Grad>();
    public DbSet<ProfilStudent> ProfiliStudenata => Set<ProfilStudent>();

    public DbSet<StudentObrazovanje> StudentObrazovanja => Set<StudentObrazovanje>();
    public DbSet<Tehnologija> Tehnologije => Set<Tehnologija>();
    public DbSet<StudentTehnologija> StudentTehnologije => Set<StudentTehnologija>();
    public DbSet<Dokument> Dokumenti => Set<Dokument>();
    public DbSet<ProfilKompanija> ProfiliKompanije => Set<ProfilKompanija>();
    public DbSet<Praksa> Prakse => Set<Praksa>();
    public DbSet<PraksaTehnologija> PraksaTehnologije => Set<PraksaTehnologija>();
    public DbSet<StatusPrijave> StatusiPrijave => Set<StatusPrijave>();
    public DbSet<StudentPraksa> StudentPrakse => Set<StudentPraksa>();
    public DbSet<FavoritPraksa> FavoritiPraksa => Set<FavoritPraksa>();
    public DbSet<Review> Reviews => Set<Review>();
    public DbSet<ChatPoruka> ChatPoruke => Set<ChatPoruka>();
    public DbSet<Notifikacija> Notifikacije => Set<Notifikacija>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
