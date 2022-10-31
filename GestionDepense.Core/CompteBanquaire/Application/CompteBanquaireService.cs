using System;
using GestionDepense.Core.CompteBanquaire.Application.Interface;
using GestionDepense.Core.CompteBanquaire.Domaine;

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

