# Gatekeeper

Gatekeeper is a fluent way to use Notification Pattern with your entities, concentrating every change you made and easy accessing it when you need.

| Package      | Version                                                                                          | Downloads                                                                                         |
| ------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------- |
| `Gatekeeper` | [![NuGet](https://img.shields.io/nuget/v/Gatekeeper.svg)](https://nuget.org/packages/Gatekeeper) | [![Nuget](https://img.shields.io/nuget/dt/Gatekeeper.svg)](https://nuget.org/packages/Gatekeeper) |

### Dependencies

.NET Standard 2.0

You can check supported frameworks here:

https://docs.microsoft.com/pt-br/dotnet/standard/net-standard

### Instalation

This package is available through Nuget Packages: https://www.nuget.org/packages/Gatekeeper

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

Just check our [Wiki](https://github.com/andrebaltieri/Gatekeeper/wiki) for more details and samples of how to use Gatekeeper in your applications.

## Extensions

- [Gatekeeper.Extensions.Br](https://github.com/andrebaltieri/Gatekeeper.Extensions.Br)
- [Gatekeeper.Extensions.AspNet](https://github.com/andrebaltieri/Gatekeeper.Extensions.AspNet)

## Mods

- [Gatekeeper.Br](https://github.com/lira92/Gatekeeper.br)
- [Gatekeeper for Java](https://github.com/carlosbritojun/jGatekeeper)
- [Gatekeeper for JavaScript](https://github.com/jhonesgoncal/Gatekeeper)
- [Gatekeeper for Python](https://github.com/Delatorrea/PyGatekeeper)
- [Gatekeeper for PHP](https://github.com/matheusbloise/Gatekeeper-php)

## About the Art

All logo, icons, colors and fonts were provided with love by Gregory Buso
