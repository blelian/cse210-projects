using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalConverter : JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var root = doc.RootElement;
            string goalType = root.GetProperty("GoalType").GetString();

            return goalType switch
            {
                "SimpleGoal" => JsonSerializer.Deserialize<SimpleGoal>(root.GetRawText(), options),
                "EternalGoal" => JsonSerializer.Deserialize<EternalGoal>(root.GetRawText(), options),
                "ChecklistGoal" => JsonSerializer.Deserialize<ChecklistGoal>(root.GetRawText(), options),
                "NegativeGoal" => JsonSerializer.Deserialize<NegativeGoal>(root.GetRawText(), options),
                _ => throw new NotSupportedException($"Goal type {goalType} is not supported.")
            };
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
