using System.Text.Json;

namespace dotnet.fluent.validation
{
    public class ErrorDetails
    {
        public string[] Errors { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
