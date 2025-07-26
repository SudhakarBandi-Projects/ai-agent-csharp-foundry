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
        string AZURE_OPENAI_ENDPOINT = "https://ai-agent-csharp-aif.openai.azure.com/";
        string AZURE_OPENAI_KEY = "{your API key}";
        string AZURE_OPENAI_DEPLOYMENT_ID= "gpt-4.1";

        var endpoint = new Uri(AZURE_OPENAI_ENDPOINT);
       
        AzureOpenAIClient azureClient = new(
            endpoint,
            new AzureKeyCredential(AZURE_OPENAI_KEY));
        ChatClient chatClient = azureClient.GetChatClient(AZURE_OPENAI_DEPLOYMENT_ID);

        Console.WriteLine("Enter your question:");
        string question = Console.ReadLine();

        List<ChatMessage> messages = new List<ChatMessage>()
        {
            new SystemChatMessage("You are a helpful assistant."),
            new UserChatMessage(question),
        };

        var response = chatClient.CompleteChat(messages);
        
        //File.WriteAllText(responsefilePath, response.Value.Content[0].Text);

        Console.WriteLine("\nAI Agent Response:\n------------------");
        Console.WriteLine(response.Value.Content[0].Text);
        Console.ReadKey();
    }
}
