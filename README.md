# Checker

[![NuGet Version](http://img.shields.io/nuget/v/Agero.Core.Checker.svg?style=flat)](https://www.nuget.org/packages/Agero.Core.Checker/) 
[![NuGet Downloads](http://img.shields.io/nuget/dt/Agero.Core.Checker.svg?style=flat)](https://www.nuget.org/packages/Agero.Core.Checker/)

Helper library that helps assert assumptions in the code. This helps to declare all assumption explicitly and continue to write code based on specified assumptions.

For example:

- Assert string argument assumption:
```csharp
void DoSomething(string name)
{
  // This code line will throw ArgumentException exception if assumption failed
  Check.ArgumentIsNullOrWhiteSpace(name, nameof(name));
  ...
}
```

- Assert class type argument assumption:
```csharp
void DoSomething(Person person)
{
  // This code line will throw ArgumentNullException exception if assumption failed
  Check.ArgumentIsNull(person, nameof(person));
  ...
}
```

- Assert custom argument assumption:
```csharp
void DoSomething(decimal price)
{
  // This code line will throw ArgumentException exception if assumption failed
  Check.Argument(price > 0, "price > 0");
  ...
}
```

- Assert custom assumption:
```csharp
void DoSomething()
{
    var response = CallApi();

    // This code line will throw InvalidOperationException exception if assumption failed
    Check.Assert(response != null, "response != null");
  ...
}
```

