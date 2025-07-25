# AI Agent from Scratch using Azure AI Foundry (C#)

This project demonstrates how to build a basic AI agent using Azure AI Foundry and C#.

## 🎯 Project Goal
Accept user input, send it to Azure OpenAI (ChatGPT), and return the response using a 3-step pipeline.

## 📁 Structure
```
ai-agent-csharp/
├── src/│   
│   ├── AzureAIClient/
```

## ⚙️ Setup
1. Create a new project in Azure AI Foundry.
   Project name as ai-agent-csharp and other details as shown in below image.
   <img width="1902" height="1022" alt="image" src="https://github.com/user-attachments/assets/0e150266-440a-4a0f-94f7-85d9b393cb79" />
2. Next we need to deploy a model for the project.
   For this demo, choose gpt-4.1 model and click on confirm.
   <img width="1913" height="1023" alt="image" src="https://github.com/user-attachments/assets/88218ee5-4060-4fd6-bbac-c11cf3c065ec" />
3. Click on deploy.
   <img width="1911" height="1023" alt="image" src="https://github.com/user-attachments/assets/4f9461aa-5169-4137-b00b-9afb22c05a22" />
4. Project will be created with All the endpoints and API key as shown in below image,
   <img width="1883" height="1022" alt="image" src="https://github.com/user-attachments/assets/ff9aa5fe-e9c6-492f-86f1-529e029f5593" />
5. Clone the project into your local repository. 
6. Add these variables in Program.cs, these variable values can be found in step 4:
```
AZURE_OPENAI_ENDPOINT=your_endpoint_url
AZURE_OPENAI_KEY=your_openai_key
AZURE_OPENAI_DEPLOYMENT_ID=your_deployment_name
```
7. Run the code:
```
dotnet run src/AzureAIClient
```
8. A console will be opened and asks the question, Enter you r question
   <img width="1185" height="609" alt="image" src="https://github.com/user-attachments/assets/7e69379c-c71b-4627-b894-68845e1da0f7" />
9. The entered question will be sent to gpt-4.1 model and model will generate the answer as the output in comsole.
   <img width="1180" height="1029" alt="image" src="https://github.com/user-attachments/assets/e724e2ec-404d-4d22-93ea-07f96a8b6e2d" />






## 📦 Requirements
- Azure OpenAI resource
- Azure AI Foundry access
- .NET SDK

## 📹 Tutorial
Watch the full video demo on YouTube: *Coming soon!*

## 📄 License
MIT
