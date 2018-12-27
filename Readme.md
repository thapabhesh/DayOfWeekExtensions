# Day of week extensions
This project is used to expore the possibility of extending `DayOfWeek` enum type in C#.

## Prerequisite
This project was built with Microsoft Visual Studio Community Edition 2017 version 15.9.4 and Dotnet Core v2.2.0.

You might need to have correct version of dotnet core sdk before running the Nunit tests on your local machine.

## Methods
The following method adds 1 day to Monday and returns Tuesday.

```csharp

DayOfWeek.Monday.AddDays(1)

```

You can use following method to get all the days between Monday to Friday.

```csharp

DayOfWeek.Monday.GetDaysBetween(DayOfWeek.Friday)

```

You can use optional parameter `includeBoundary: false` if you do not want to include edges in your result.
