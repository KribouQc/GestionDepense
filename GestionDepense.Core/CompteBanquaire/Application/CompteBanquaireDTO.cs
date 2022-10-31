using System;
namespace GestionDepense.Core.CompteBanquaire.Application
{
	public class CompteBanquaireDTO
	{
		public Guid IdCompteBanquaire { get; set; }
		public string NomBanque { get; set; } = default!;
	}
}

