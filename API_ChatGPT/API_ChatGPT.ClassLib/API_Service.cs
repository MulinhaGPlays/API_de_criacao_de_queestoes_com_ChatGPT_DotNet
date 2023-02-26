using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3;

namespace API_ChatGPT.ClassLib;

public class API_Service
{
    public async Task<string?> RequestResult(string text, string apiKey)
    {
        var openAiService = new OpenAIService(new OpenAiOptions()
        {
            ApiKey = apiKey
        });

        var completionResult = await openAiService.Completions.CreateCompletion(new CompletionCreateRequest()
        {
            Prompt = text,
            Model = Models.TextDavinciV3,
            MaxTokens = 3000,
        });

        return completionResult.Choices.FirstOrDefault()?.Text;
    }
}