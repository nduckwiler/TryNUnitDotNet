I created this repo using Visual Studio 2019 (8.0.2) on Mac. Here are my steps...

## Create the project
File > New Solution... > .NET Core > Console Application

![Creating project](https://s3.amazonaws.com/codecademy-content/courses/learn-c-sharp/test-framework-assets/create-console-app-project.png)

## Add NuGet packages for testing:
Project > Add NuGet Packages... 
* Add Microsoft.NET.Test.Sdk
* Add NUnit
* Add NUnit3TestAdapter

![Adding packages](https://s3.amazonaws.com/codecademy-content/courses/learn-c-sharp/test-framework-assets/add-nuget-packages.png)

## Allow console app and tests to work in the same assembly
Open `.csproj` file and, inside a `<PropertyGroup>` element, add: 
```
<GenerateProgramFile>false</GenerateProgramFile>
```
I was not able to view my `.csproj` file with Visual Studio, so I used a separate text editor.

## Run the app in Visual Studio
Click the run button.

## Run the tests in Visual Studio
View > Test (to open test layout)

Run > Run Unit Tests

![Running tests in Visual Studio](https://s3.amazonaws.com/codecademy-content/courses/learn-c-sharp/test-framework-assets/run-tests-visual-studio.png)

## Run the app in .NET Core CLI
Navigate to project directory and run:
```
dotnet run
```

## Run the tests in .NET Core CLI
Navigate to project directory and run:
```
dotnet test
```
![Running tests in .NET Core CLI](https://s3.amazonaws.com/codecademy-content/courses/learn-c-sharp/test-framework-assets/run-tests-dot-net-cli.png)
