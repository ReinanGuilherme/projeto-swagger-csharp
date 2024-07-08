using System.Reflection;
using Microsoft.OpenApi.Models;
using SwaggerCSharp.Api.DTO.SwaggerExemplos;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SwaggerCSharp.Api.Filters
{
	public class CustomParameterFilter : IParameterFilter
	{
		public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
		{
			IEnumerable<SwaggerParameterExemplo>? parameterAttributos = null;

            if (context.PropertyInfo is not null)
            {
				parameterAttributos = context.PropertyInfo.GetCustomAttributes<SwaggerParameterExemplo>();
            } else if (context.ParameterInfo is not null)
			{
				parameterAttributos = context.ParameterInfo.GetCustomAttributes<SwaggerParameterExemplo>();
			}

			if(parameterAttributos != null && parameterAttributos.Any())
			{
				AddExample(parameter, parameterAttributos);
			}
        }

		private void AddExample(OpenApiParameter parameter, IEnumerable<SwaggerParameterExemplo> parameterAttributos)
		{
            foreach (var item in parameterAttributos)
            {
				var example = new OpenApiExample
				{
					Value = new Microsoft.OpenApi.Any.OpenApiString(item.Value)
				};
				parameter.Examples.Add(item.Name, example);
            }
        }
	}
}
