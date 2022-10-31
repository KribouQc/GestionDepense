using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gestion_Depense_core.CompteBanquaire.Application.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestion_depense_API.Controllers
{
    [Route("api/[controller]")]
    public class CompteBanquaireController : ControllerBase
    {
        private ICompteBanquaireService _compteBanquaireService;

        public CompteBanquaireController(ICompteBanquaireService compteBanquaireService)
        {
            _compteBanquaireService = compteBanquaireService;
        }


        [HttpGet]
        public IActionResult GetCompte()
        {
           
            
            return Ok(_compteBanquaireService.GetCompteBanquaires());
        }
        
    }
}

