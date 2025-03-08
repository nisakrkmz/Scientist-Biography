using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using DotNetEnv;

namespace NetCoreProject_1.Models;
public class OpenAiService
{
    private readonly HttpClient _httpClient;
    private const string OpenAiUrl = "https://api.openai.com/v1/chat/completions";
    private readonly string apiKey;
    public OpenAiService()
    {
        Env.Load(Path.Combine(Directory.GetCurrentDirectory(), ".env"));
        apiKey = Env.GetString("OPENAI_API_KEY");
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
    }

    public async Task<string> GetScientistLifeAsync(string scientistName)
    {
        var requestBody = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new { role = "system", content = "You are a historian with expertise in famous scientists. You have been given the following details about a scientist's life." },
                new { role = "user", content = $"Tell me about the life of {scientistName}." }
            },
            temperature = 0.7
        };

        var jsonRequest = JsonSerializer.Serialize(requestBody);
        var response = await _httpClient.PostAsync(OpenAiUrl, new StringContent(jsonRequest, Encoding.UTF8, "application/json"));

        if (!response.IsSuccessStatusCode)
        {
            return "Error: Unable to get a response from OpenAI.";
        }

        var responseBody = await response.Content.ReadAsStringAsync();
        var doc = JsonDocument.Parse(responseBody);

        if (doc.RootElement.TryGetProperty("choices", out var choices) && choices.GetArrayLength() > 0)
        {
            return choices[0].GetProperty("message").GetProperty("content").GetString();
        }

        return "No scientist information found.";
    }
}
