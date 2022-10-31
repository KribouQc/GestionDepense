using System;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Depense_core.CompteBanquaire.Domaine;

	public class Compte
	{
        [Key]
        public Guid IdCompteBanquaire { get; set; }
        public string NomBanque { get; set; } = default!;
        public TypeCompteBanquaire TypeCompteBanquaire { get; set; } = default!;
    }

public enum TypeCompteBanquaire
{
    Credit,
    Debit
}