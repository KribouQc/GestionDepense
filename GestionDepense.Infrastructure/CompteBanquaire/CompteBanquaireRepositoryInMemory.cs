using System;
using GestionDepense.Core.CompteBanquaire.Domaine;
using GestionDepense.Core.CompteBanquaire.Application.Interface;
using GestionDepense.Infrastructure.Data;
using AutoMapper;

namespace GestionDepense.Infrastructure.CompteBanquaire;

public class CompteBanquaireRepositoryInMemory : ICompteBanquaireRepository
{
    private UniteDeTravailInMemory _uniteTravailInMemory;
    private readonly IMapper _mapper;


    public CompteBanquaireRepositoryInMemory(UniteDeTravailInMemory uniteDeTravailInMemory, IMapper mapper)
    {
        _uniteTravailInMemory = uniteDeTravailInMemory;
        _mapper = mapper;
    }

    public void CreerCompte(CompteCreation compte)
    {
        Compte compteBD = _mapper.Map<CompteCreation,Compte>(compte);
        _uniteTravailInMemory.Add(compteBD);
        _uniteTravailInMemory.SaveChanges();

    }

    public Compte GetCompteBanquaire(Guid idCompte)
    {
        return _uniteTravailInMemory.ComptesBanquaires!.FirstOrDefault(c => c.IdCompteBanquaire == idCompte)!;
    }

    public List<Compte> GetComptesBanquaires()
    {
        return _uniteTravailInMemory.ComptesBanquaires!.Select(c => c).ToList();
    }
}


