# Lab06 Interfaces
This exercise implements the concepts of Interfaces using a zoo as the running theme.

---
## Concepts Implemented
Interfaces are like abstract classes in that they have behaviours that classes can implement.  
They allow classes to behave a certain way instead of having a class inherit these behaviours 
based on a hierarchical class inheritance.

---

## Interfaces Used
The interfaces used in this console app includes ISwimAndKill and IFly.
Both interfaces are implemented in the Bear and Shark class to
prove that they can be used on multiple concrete classes.

---

## Dependencies
This exercise runs on .NET Core 2.1, which can be downloaded [here](https://www.microsoft.com/net/download/macos).

---
## Build
After installing the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/macos), clone this repo onto your machine. From a terminal interface, go to where this was cloned and type the following commands:

```
cd Lab06_BuildAZoo
dotnet restore
dotnet run
```

---
## How to Use the Program
The console will log messages that will demonstrate that concrete classes have inherited from their base classes.

---

## Screenshots
Diagram of zoo hierarchy

![Hierarchy Diagram](/assets/zoo.png)

Console Output:

![Console Output](/assets/zooConsoleOutput.png)

## Acknowledgements
- Many thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this awesome README layout.