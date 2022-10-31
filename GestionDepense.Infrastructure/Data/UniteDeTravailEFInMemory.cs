using System;
using Microsoft.EntityFrameworkCore;
using GestionDepense.Core.CompteBanquaire.Domaine;

namespace Gestion_Depense_Infrastructure.Data;

public class UniteDeTravailInMemory : DbContext
{
    public UniteDeTravailInMemory (DbContextOptions<UniteDeTravailInMemory> options) : base(options)
    {
        //optionsBuilder.UseInMemoryDatabase(databaseName: "DepenseBd");
    }
    public DbSet<Compte>? ComptesBanquaires { get; set; }
}

