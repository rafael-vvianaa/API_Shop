using System.Collections.Generic;
using System.Threading.Tasks;
using API_SHOP.Models;
using Microsoft.AspNetCore.Mvc;
[Route("categorias")]
public class CategoriaController : ControllerBase
{

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<Categoria>> ObterCategoria()
    {
        return new Categoria();
    }

    [HttpGet]
    [Route("{id:int}")]// ':int' usado para permitir somente inteiros
    public async Task<ActionResult<List<Categoria>>> GetById(int id)
    {
        return new List<Categoria>();
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<List<Categoria>>> Post([FromBody] Categoria categoriaModel)
    {
        // FromBody utilizado para fazer a busca da Categoria categoriaModel
        // ou seja uma categoria no corpo da requisição

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(categoriaModel);
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Categoria>>> Delete()
    {
        return Ok();
    }

    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Categoria>>> Update(int id, [FromBody] Categoria categoriaModel)
    {

        //verificar mesmo ID 

        if (id != categoriaModel.Id)
            return NotFound(new { message = "Esta categoria não foi encontrada." });

     //verificaçao dos dados se são vaildos.
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(categoriaModel);

    }

}