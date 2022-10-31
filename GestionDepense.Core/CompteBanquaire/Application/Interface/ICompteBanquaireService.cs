using System;
using Gestion_Depense_core.CompteBanquaire.Domaine;

namespace Gestion_Depense_core.CompteBanquaire.Application.Interface
{
	public interface ICompteBanquaireService
	{
		public List<Compte> GetCompteBanquaires();
		public void CreerCompte(CompteCreation compte);
	}
}

