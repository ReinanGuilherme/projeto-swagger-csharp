using System.Globalization;

namespace SwaggerCSharp.Api.DTO.SwaggerExemplos
{
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = true)]
	public class SwaggerParameterExemplo : Attribute
	{
        public string Name { get; set; }
        public string Value { get; set; }
        public SwaggerParameterExemplo(string name, string value)
        {
            Name = name;
            Value = value;
        }
        
        public SwaggerParameterExemplo( string value)
        {
            Name = value;
            Value = value;
        }
    }
}
