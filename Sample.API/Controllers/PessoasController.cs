using Microsoft.AspNetCore.Mvc;
using Sample.Application.Services.Interfaces;
using Sample.Domain.Models;
using System.Collections.Generic;

namespace Sample.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController: ControllerBase
    {
        public IPessoaService PessoaService { get; }

        public PessoasController(IPessoaService pessoaService)
        {
            PessoaService = pessoaService
                ?? throw new System.ArgumentNullException(nameof(pessoaService));
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(PessoaService.Get());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(PessoaService.GetByID(id));
        }

        [HttpPost("")]
        public IActionResult Add([FromBody]Pessoa pessoa)
        {
            PessoaService.Insert(pessoa);
            return Ok();
        }

        [HttpPut("")]
        public IActionResult Update(Pessoa pessoa)
        {
            PessoaService.Update(pessoa);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            PessoaService.Delete(id);
            return Ok();
        }

    }
}
