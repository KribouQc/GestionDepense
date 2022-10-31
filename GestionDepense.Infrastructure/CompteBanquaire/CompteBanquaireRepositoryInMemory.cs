using System;
using GestionDepense.Core.CompteBanquaire.Domaine;
using GestionDepense.Core.CompteBanquaire.Application.Interface;

using Gestion_Depense_Infrastructure.Data;

namespace Gestion_Depense_Infrastructure.CompteBanquaire;

public class CompteBanquaireRepositoryInMemory : ICompteBanquaireRepository
{
    private UniteDeTravailInMemory _uniteTravailInMemory;

    public CompteBanquaireRepositoryInMemory(UniteDeTravailInMemory uniteDeTravailInMemory)
    {
        _uniteTravailInMemory = uniteDeTravailInMemory;
    }

    public void CreerCompte(CompteCreation compte)
    {
        
        _uniteTravailInMemory.Add(compte);
        _uniteTravailInMemory.SaveChanges();

    }

    public List<Compte> GetCompteBanquaires()
    {
        return _uniteTravailInMemory.ComptesBanquaires!.Select(c => c).ToList();
    }
}


