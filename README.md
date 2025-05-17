# Gatekeeper

Gatekeeper is a fluent way to use Notification Pattern with your entities, concentrating every change you made and easy accessing it when you need.

| Package      | Version                                                                                                                   | Downloads                                                                                                                  |
| ------------ | ------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- |
| `Gatekeeper` | [![NuGet](https://img.shields.io/nuget/v/NexumPack.Gatekeeper.svg)](https://www.nuget.org/packages/NexumPack.Gatekeeper/) | [![Nuget](https://img.shields.io/nuget/dt/NexumPack.Gatekeeper.svg)](https://www.nuget.org/packages/NexumPack.Gatekeeper/) |

### Dependencies

.NET Standard 2.0

You can check supported frameworks here:

https://docs.microsoft.com/pt-br/dotnet/standard/net-standard

### Instalation

This package is available through Nuget Packages: https://www.nuget.org/packages/NexumPack.Gatekeeper/

**Nuget**

```
Install-Package Gatekeeper
```

**.NET CLI**

```
dotnet add package Gatekeeper
```

## How to use

```csharp
public class Customer : Notifiable<Notification>
{
  ...
}

var customer = new Customer();
customer.AddNotification("Name", "Invalid name");

if(customer.IsValid)
  ...
```

Just check our [Wiki](https://github.com/lucaseduardocrp/Gatekeeper/wiki) for more details and samples of how to use Gatekeeper in your applications.

## About the Art

All logo, icons, colors and fonts were provided with love by Gregory Buso
