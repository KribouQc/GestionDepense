using System;
using GestionDepense.Core.CompteBanquaire.Domaine;

namespace GestionDepense.Core.CompteBanquaire.Application.Interface
{
	public interface ICompteBanquaireService
	{
		public List<Compte> GetCompteBanquaires();
		public void CreerCompte(CompteCreation compte);
	}
}

