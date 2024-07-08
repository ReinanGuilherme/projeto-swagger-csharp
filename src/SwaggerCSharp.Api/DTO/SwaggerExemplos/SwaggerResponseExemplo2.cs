using SwaggerCSharp.Api.DTO.Responses;
using Swashbuckle.AspNetCore.Filters;

namespace SwaggerCSharp.Api.DTO.SwaggerExemplos
{
	public class SwaggerResponseExemplo2 : IMultipleExamplesProvider<ResponseExemplo2>
	{
		public IEnumerable<SwaggerExample<ResponseExemplo2>> GetExamples()
		{
			yield return SwaggerExample.Create(
				"Exemplo 1",
				new ResponseExemplo2()
				{
					Nome = "Reinan",
					Sobrenome = "Guilherme",
					DataNascimento = new DateTime(1997, 2, 1),
				});
			
			yield return SwaggerExample.Create(
				"Exemplo 2",
				new ResponseExemplo2()
				{
					Nome = "Jessica",
					Sobrenome = "Carvalho",
					DataNascimento = new DateTime(2000, 1, 10),
				});
		}

	}
}
