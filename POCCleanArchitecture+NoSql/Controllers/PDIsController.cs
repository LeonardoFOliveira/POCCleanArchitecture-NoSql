using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POCCleanArchitecture_NoSql.ApplicationCore.Entities;
using POCCleanArchitecture_NoSql.ApplicationCore.Interfaces.Services;

namespace POCCleanArchitecture_NoSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDIsController : ControllerBase
    {
        private readonly IPDIService _PDIService;

        public PDIsController(IPDIService PDIService)
        {
            _PDIService = PDIService;
        }

        [HttpGet]
        public ActionResult<List<PDI>> Get() =>
            _PDIService.GetAllPDIs();

        [HttpGet("{id:length(24)}", Name = "GetPDI")]
        public ActionResult<PDI> Get(string id)
        {
            var pdi = _PDIService.GetPDIById(id);

            if (pdi == null)
            {
                return NotFound();
            }

            return pdi;
        }

        [HttpPost]
        public ActionResult<PDI> Create(PDI pdi)
        {
            _PDIService.CreatePDI(pdi);

            return CreatedAtRoute("GetPDI", new { id = pdi.Id.ToString() }, pdi);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, PDI bookIn)
        {
            var pdiAfter = _PDIService.UpdatePDI(id, bookIn);

            if (pdiAfter == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var pdiAfterDeleted = _PDIService.DeletePDI(id);

            if (pdiAfterDeleted == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
