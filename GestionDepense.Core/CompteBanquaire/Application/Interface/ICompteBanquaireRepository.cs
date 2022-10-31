using System;
using GestionDepense.Core.CompteBanquaire.Domaine;

namespace GestionDepense.Core.CompteBanquaire.Application.Interface;

    public interface ICompteBanquaireRepository
	{
		
        public List<Compte> GetCompteBanquaires();
        public void CreerCompte(CompteCreation compte);
        
    }


