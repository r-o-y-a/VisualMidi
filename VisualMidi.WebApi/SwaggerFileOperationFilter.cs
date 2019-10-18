using System.Collections.Generic;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace VisualMidi.WebApi
{
    public class SwaggerFileOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            if (operation.OperationId == "Post")
            {
                operation.Parameters = new List<IParameter>
                {
                    new NonBodyParameter
                    {
                        Name = "fileName",
                        Required = true,
                        Type = "file",
                        In = "formData"
                    }
                };
            }
        }
    }
}
