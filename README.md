<img src="Toolblox/Assets/Images/blocks.png" alt="contrast-icon" width="64" height="64" align="right" hspace="0" vspace="3" style="margin-left: 25px;"/>
## Toolblox
A one-stop library for common utilities for developing .NET applications.

![Master Build](https://github.com/cognophile/Toolblox/actions/workflows/build.yml/badge.svg)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=cognophile_Toolblox&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=cognophile_Toolblox)
![Nuget](https://img.shields.io/nuget/v/Cognophile.Toolblox)

---

### Introduction
`Toolblox` aims to be the only utility-providing library you need for any .NET project by covering as much commonly required behaviour as possible.

#### Behavioural Summary
* Boolean: Access to common boolean-based extension behaviours. 
* Collections: Access to common collection extension behaviours.
* Dates: Access to common date extension behaviours.
* JSON: Access to common JSON-based behaviours.
* Numbers: Access to common numeric-based extension behaviours.
* Objects: Access to generic object extension behaviours.
* Strings: Access to common string-based extension behaviours.

### Support
If you find this library useful and wish to take a moment to say a simple thanks, or support its development, then a star or donation would be hugely appreciated!

<a href="https://www.buymeacoffee.com/cognophile"><img src="https://img.buymeacoffee.com/button-api/?text=Buy me a coffee&emoji=&slug=cognophile&button_colour=FFDD00&font_colour=000000&font_family=Cookie&outline_colour=000000&coffee_colour=ffffff"></a>

### Installation

### Documentation
Documentation of the available behaviours can be found within the wiki, here.

#### Usage
`Toolblox` can be interfaced with in multiple ways, either via an instance, a static call, or an extension method. 

#### Instances
```csharp
using Cognophile.Toolblox;
...

public static void DoSomething(string myString)
{
    ...
    Toolblox blox = new();
    bool result = blox.StringBlock.IsNull(myString);
    ...
}
```

#### Statically
```csharp
using Cognophile.Toolblox;
...

public static void DoSomething(string myString)
{
    ...
    var result = Toolblox.Strings.IsNull(myString);
    ...
}
```

#### Extensions
```csharp
using Cognophile.Toolblox.Blocks.Extensions.Strings;
...

public static void DoSomething(string myString)
{
    ...
    var result = myString.IsNull();
    ...
}
```

### Dependencies 
* [Aradlis GuardClauses](https://github.com/ardalis/GuardClauses)

### Contributing
Contributions of all kinds are welcome - whether it be submitting a suggestion for how the library could be improved or extended, or by submitting a pull request with the completed work to the project. However, before submitting any suggestions, please read through [`CONTRIBUTING.md`](https://github.com/cognophile/Toolblox/blob/master/CONTRIBUTING.md) to ensure your work is in the best state to be accepted.

---
<sub>Icon attribution: <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></sub>