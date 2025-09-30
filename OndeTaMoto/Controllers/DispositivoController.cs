using OndeTaMotoBusiness;
using OndeTaMotoModel;
using Microsoft.AspNetCore.Mvc;

namespace OndeTaMotoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DispositivoController : ControllerBase
{
    private readonly DispositivoService _dispositivoService;

    public DispositivoController(DispositivoService dispositivoService)
    {
        _dispositivoService = dispositivoService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var dispositivos = _dispositivoService.ListarTodos();
        return dispositivos.Count == 0 ? NoContent() : Ok(dispositivos);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var dispositivo = _dispositivoService.ObterPorId(id);
        return dispositivo == null ? NotFound() : Ok(dispositivo);
    }

    [HttpPost]
    public IActionResult Post([FromBody] DispositivoModel novoDispositivo)
    {
        if (string.IsNullOrWhiteSpace(novoDispositivo.Nome))
            return BadRequest("Nome é obrigatório.");

        var criado = _dispositivoService.Criar(novoDispositivo);
        return CreatedAtAction(nameof(Get), new { id = criado.Id }, criado);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] DispositivoModel dispositivoAtualizado)
    {
        if (dispositivoAtualizado == null || dispositivoAtualizado.Id != id)
            return BadRequest("Dados inconsistentes.");

        return _dispositivoService.Atualizar(dispositivoAtualizado) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return _dispositivoService.Remover(id) ? NoContent() : NotFound();
    }
}
