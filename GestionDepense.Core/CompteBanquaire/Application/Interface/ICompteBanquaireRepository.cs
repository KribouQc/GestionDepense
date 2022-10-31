using System;
using GestionDepense.Core.CompteBanquaire.Domaine;

namespace GestionDepense.Core.CompteBanquaire.Application.Interface;

    public interface ICompteBanquaireRepository
	{
		
        public List<Compte> GetComptesBanquaires();
        public Compte GetCompteBanquaire(Guid idCompte);
        public void CreerCompte(CompteCreation compte);
        
    }


