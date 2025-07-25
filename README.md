# AI Agent from Scratch using Azure AI Foundry (C#)

This project demonstrates how to build a basic AI agent using Azure AI Foundry and C#.

## 🎯 Project Goal
Accept user input, send it to Azure OpenAI (ChatGPT), and return the response using a 3-step pipeline.

## 📁 Structure
```
ai-agent-csharp/
├── .azure-ai-foundry/
│   └── pipeline.yaml
├── data/
│   ├── user_input.txt
│   └── response_raw.json
├── src/
│   ├── InputHandler/
│   ├── AzureAIClient/
│   └── ResponseFormatter/
```

## ⚙️ Setup
1. Add these environment variables:
```
AZURE_OPENAI_ENDPOINT=your_endpoint_url
AZURE_OPENAI_KEY=your_openai_key
AZURE_OPENAI_DEPLOYMENT_ID=your_deployment_name
```
2. Run via Azure AI Foundry:
```
foundry run .azure-ai-foundry/pipeline.yaml
```
<img width="1902" height="1022" alt="image" src="https://github.com/user-attachments/assets/0e150266-440a-4a0f-94f7-85d9b393cb79" />

## 📦 Requirements
- Azure OpenAI resource
- Azure AI Foundry access
- .NET SDK

## 📹 Tutorial
Watch the full video demo on YouTube: *Coming soon!*

## 📄 License
MIT
