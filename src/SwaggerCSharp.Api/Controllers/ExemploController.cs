using Microsoft.AspNetCore.Mvc;
using SwaggerCSharp.Api.DTO.Requests;
using SwaggerCSharp.Api.DTO.Responses;
using SwaggerCSharp.Api.DTO.SwaggerExemplos;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace SwaggerCSharp.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ExemploController : ControllerBase
	{
		[HttpGet("exemplo1")]
		[SwaggerOperation(
			Summary = "Obtém exemplo sumário e descrição usando Swagger.", 
			Description = "Este endpoint demonstra como adicionar sumário e descrição usando Swagger."
		)]
		public IActionResult Exemplo1()
		{
			return Ok();
		}

		[HttpGet("exemplo2")]
		[SwaggerOperation(
			Summary = "Obtém uma resposta de exemplo usando Swagger.",
			Description = "Este endpoint demonstra como adicionar uma resposta de exemplo usando Swagger."
		)]
		[ProducesResponseType(typeof(SwaggerResponseExemplo2), StatusCodes.Status200OK)]
		[SwaggerResponseExample(200, typeof(SwaggerResponseExemplo2))]
		public IActionResult Exemplo2()
		{
			var response = new ResponseExemplo2
			{
				Nome = "Reinan",
				Sobrenome = "Guilherme",
				DataNascimento = new DateTime(1997, 2, 1)
			};

			return Ok(response);
		}

		[HttpPost("exemplo3")]
		[SwaggerOperation(
			Summary = "Obtém uma request body de exemplo usando Swagger.",
			Description = "Este endpoint demonstra como adicionar uma request body de exemplo usando Swagger."
		)]
		[SwaggerRequestExample(typeof(RequestExemplo3), typeof(SwaggerRequestExemplo3))]
		public IActionResult Exemplo3([FromBody] RequestExemplo3 request)
		{
			return Ok();
		}
	}
}
