using System;
namespace Gestion_Depense_core.CompteBanquaire.Application
{
	public class CompteBanquaireDTO
	{
		public Guid IdCompteBanquaire { get; set; }
		public string NomBanque { get; set; } = default!;
	}
}

