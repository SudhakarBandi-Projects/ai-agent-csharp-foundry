using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenAI.Chat;
using Azure;
using Azure.AI.OpenAI;

class Program
{
    static async Task Main()
    {        
        string relativeresponsefilePath = Path.Combine("..", "..", "..", "..","..", "data", "response_raw.json");
        string responsefilePath = Path.GetFullPath(relativeresponsefilePath);

        string relativeuserinputPath = Path.Combine("..", "..", "..", "..", "..", "data", "user_input.txt");
        string userinputfilePath = Path.GetFullPath(relativeuserinputPath);

        var endpoint = new Uri("https://ai-agent-csharp-resource.openai.azure.com/");
        string key = "9l0BeoXv8ziotGTOB47Cnin4uvDhvv2R7QoEt01aRzvs8pA1xBmkJQQJ99BGACHYHv6XJ3w3AAAAACOGFXgP";
        string deploymentId = "gpt-4.1";

        AzureOpenAIClient azureClient = new(
            endpoint,
            new AzureKeyCredential(key));
        ChatClient chatClient = azureClient.GetChatClient(deploymentId);

        List<ChatMessage> messages = new List<ChatMessage>()
        {
            new SystemChatMessage("You are a helpful assistant."),
            new UserChatMessage(File.ReadAllText(userinputfilePath)),
        };

        var response = chatClient.CompleteChat(messages);
        
        File.WriteAllText(responsefilePath, response.Value.Content[0].Text);
    }
}