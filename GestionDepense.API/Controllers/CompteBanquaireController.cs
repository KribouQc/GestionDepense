using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDepense.Core.CompteBanquaire.Application.Interface;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestiondepense.API.Controllers
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

