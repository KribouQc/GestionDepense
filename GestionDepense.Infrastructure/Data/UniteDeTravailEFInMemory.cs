using System;
using Microsoft.EntityFrameworkCore;
using GestionDepense.Core.CompteBanquaire.Domaine;

namespace GestionDepense.Infrastructure.Data;

public class UniteDeTravailInMemory : DbContext
{
    public UniteDeTravailInMemory (DbContextOptions<UniteDeTravailInMemory> options) : base(options)
    {
        
    }
    public DbSet<Compte>? ComptesBanquaires { get; set; }
}

