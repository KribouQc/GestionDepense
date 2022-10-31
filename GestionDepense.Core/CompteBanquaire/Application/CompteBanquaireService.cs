using System;
using Gestion_Depense_core.CompteBanquaire.Application.Interface;
using Gestion_Depense_core.CompteBanquaire.Domaine;

namespace Gestion_Depense_core.CompteBanquaire.Application
{
	public class CompteBanquaireService : ICompteBanquaireService
	{
        private ICompteBanquaireRepository _compteBanquaireRepository;


        public CompteBanquaireService(ICompteBanquaireRepository compteBanquaireRepository)
		{
            _compteBanquaireRepository = compteBanquaireRepository;
		}

        public void CreerCompte(CompteCreation compte)
        {

            _compteBanquaireRepository.CreerCompte(compte);
        }

        public List<Compte> GetCompteBanquaires()
        {
            return _compteBanquaireRepository.GetCompteBanquaires();
        }
    }
}

