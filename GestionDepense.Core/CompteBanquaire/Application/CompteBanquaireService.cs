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

        public Compte GetCompteBanquaire(Guid idCompte)
        {
            return _compteBanquaireRepository.GetCompteBanquaire(idCompte);
        }

        public List<Compte> GetComptesBanquaires()
        {
            return _compteBanquaireRepository.GetComptesBanquaires();
        }

       
    }
}

