// See https://aka.ms/new-console-template for more information
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

Console.WriteLine("Hello, World!");

IChatCompletionService service = new OpenAIChatCompletionService("gpt-4o-mini", Environment.GetEnvironmentVariable("OPEN_AI_API_KEY");

ChatHistory history = new ChatHistory();

history.AddUserMessage("Ravi is 34 years old");

while (true)
{
    Console.WriteLine("Q:");
    history.AddUserMessage(Console.ReadLine());

    var assistant = await service.GetChatMessageContentAsync(history);
    history.Add(assistant);

    Console.WriteLine(assistant);
}