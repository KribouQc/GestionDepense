using System;
using AutoMapper;
using GestionDepense.Core.CompteBanquaire.Domaine;

namespace GestionDepense.Infrastructure
{
	public class AutoMapperProfil : Profile
	{
		public AutoMapperProfil()
		{
			CreateMap<CompteCreation, Compte>();
				
            
				
        }
	}
}

