using System;
using System.ComponentModel.DataAnnotations;

namespace GestionDepense.Core.CompteBanquaire.Domaine;

	public class CompteCreation
	{
        [Key]
        public string NomBanque { get; set; } = default!;
        public TypeCompteBanquaire TypeCompteBanquaire { get; set; } = default!;
    }



