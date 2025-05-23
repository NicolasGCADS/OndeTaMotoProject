using OndeTaMotoBusiness;
using OndeTaMotoModel;
using Microsoft.AspNetCore.Mvc;

namespace OndeTaMotoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MotoController : ControllerBase
{
    private readonly MotoService _motoService;

    public MotoController(MotoService motoService)
    {
        _motoService = motoService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var motos = _motoService.ListarTodos();
        return motos.Count == 0 ? NoContent() : Ok(motos);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var moto = _motoService.ObterPorId(id);
        return moto == null ? NotFound() : Ok(moto);
    }

    [HttpPost]
    public IActionResult Post([FromBody] MotoModel moto)
    {
        if (string.IsNullOrWhiteSpace(moto.Nome))
            return BadRequest("Nome é obrigatório.");

        var criado = _motoService.Criar(moto);
        return CreatedAtAction(nameof(Get), new { id = criado.Id }, criado);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] MotoModel moto)
    {
        if (moto == null || moto.Id != id)
            return BadRequest("Dados inconsistentes.");

        return _motoService.Atualizar(moto) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return _motoService.Remover(id) ? NoContent() : NotFound();
    }
}
