# ModularPipelines.Pulumi

A lightweight library for integrating Pulumi CLI commands into Modular Pipelines. Easily manage Pulumi stacks, previews, deployments, and configurations in your .NET pipelines.

[![nuget](https://img.shields.io/nuget/v/ModularPipelines.Pulumi.svg)](https://www.nuget.org/packages/ModularPipelines.Pulumi/)  
![Nuget](https://img.shields.io/nuget/dt/ModularPipelines.Pulumi)

---

## **About**

ModularPipelines.Pulumi extends the ModularPipelines framework with typed, easy-to-use wrappers for Pulumi CLI commands. It enables seamless integration of Pulumi's modern infrastructure as code capabilities directly into your .NET-based pipelines.

> **Note**: This package builds upon the incredible work of [ModularPipelines](https://github.com/thomhurst/ModularPipelines) by [thomhurst](https://github.com/thomhurst). Full credit goes to the original library for its powerful pipeline abstraction.

---

## **Features**

- Strongly typed Pulumi CLI command wrappers
- Supports critical commands such as:
  - `pulumi login` for authentication
  - `pulumi stack` for retrieving stack details and secrets
  - `pulumi preview` for change visualization
  - `pulumi up` for deployments
- Built-in support for commonly used CLI options
- Easily extendable for future Pulumi commands
- Compatible with the ModularPipelines framework for a unified experience

---

## **Installation**

Install the NuGet package:

```bash
dotnet add package ModularPipelines.Pulumi
```

## **Getting Started**

**Example: Using Pulumi in a Modular Pipeline**

```csharp
using ModularPipelines.Pulumi;
using ModularPipelines.Pulumi.Options;

var pulumi = new Pulumi(command);

// Authenticate with Pulumi
await pulumi.Login(new PulumiLoginOptions
{
    CloudUrl = "https://app.pulumi.com",
    Local = false
});

// Preview changes
await pulumi.Preview(new PulumiPreviewOptions
{
    Stack = "dev",
    Json = true
});

// Deploy changes
await pulumi.Up(new PulumiUpOptions
{
    Stack = "dev",
    Yes = true
});
```

## **Supported Commands**
	•	pulumi login: Authenticate with Pulumi Cloud or local backend.
	•	pulumi stack: Manage and inspect stacks.
	•	pulumi preview: Preview changes to resources.
	•	pulumi up: Apply changes and deploy resources.

## **Credits**

This package is an extension of the ModularPipelines framework, originally developed by [thomhurst](https://github.com/thomhurst).
For more information about ModularPipelines, visit [ModularPipelines](https://github.com/thomhurst/ModularPipelines) on GitHub.

Pulumi is a powerful infrastructure-as-code platform that enables seamless cloud resource management. Learn more about Pulumi at [pulumi.com](https://www.pulumi.com/) or on [GitHub](https://github.com/pulumi).

## **Contributing**

Contributions are welcome! If you have ideas for additional features or commands, feel free to submit an issue or a pull request.

## **License**

This project is licensed under the MIT License.
