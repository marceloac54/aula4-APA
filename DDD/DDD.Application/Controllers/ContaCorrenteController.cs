using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DDD.Domain.Entities;
using DDD.Service.Services;
using DDD.Service.Validators;

namespace DDD.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ContaCorrenteController : ControllerBase
    {
        private ContaCorrenteService<ContaCorrenteDTO> service = new ContaCorrenteService<ContaCorrenteDTO>();

        [HttpPut]
        public IActionResult DebitarEmConta([FromBody] ContaCorrenteDTO item)
        {
            try
            {
                var resultado = service.DebitarEmConta<ContaCorrenteValidator>(item);

                return new ObjectResult("OK");
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult CreditarEmConta([FromBody] ContaCorrenteDTO item)
        {
            try
            {
                var resultado = service.CreditarEmConta<ContaCorrenteValidator>(item);

                return new ObjectResult("OK");
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}