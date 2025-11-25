using System.Text.Json.Serialization;

namespace JsonSerialization;

public class Employee
{
    [JsonPropertyName("employee_name")]
    public string? Name { get; set; }

    [JsonPropertyName("employee_age")]
    public int Age { get; set; }

    [JsonPropertyName("employee_role")]
    public string? Role { get; set; }

    [JsonPropertyName("employee_id")]
    public int Id { get; set; }
}
