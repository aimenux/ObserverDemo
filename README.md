# Welcome to ObserverDemo !

> Observer pattern is a software design pattern in which an object, called the *subject*, maintains a list of its dependents, called *observers*, and notifies them automatically of any state changes, usually by calling one of their methods.

Here are 6 different implementations of observer design pattern. Each implementation is illustrated through an example.
Each example contains 2 projects : a class library and a console application.

The use case consists of notifing observers of any change in subject state property.

**Technical requirements** : .NET 4.6.1, VS 17 

## Example1
This is the most basic implementation. It can be easily translated into any other programming language.

>Subject is aware of observers (maintains a collection of observers and iterate over them when state change in order to call update operation).

>Observer is aware of subject (maintains a reference on subject that will be used to get its state when update operation is called)

Drawbacks : 
- The notification of state changes is made explicitly.
- The strong coupling betweeen the subject and the observers.

## Example2
This is also a basic implementation. It's very similar to example1 but more improved version.

>Subject is aware of observers (maintains a collection of observers and iterate over them when state change in order to call update operation).

>Observer is not aware of subject. subject will be passed as an argument to the update operation.

Advantages :
- No need to call notification explicitly.
- Less coupling between subject and the observers.

## Example3
This is a .NET specific implementation based on custom delegates and events.

## Example4
This is a .NET specific implementation based on generic event handler and custom event args.

## Example5
This is a .NET specific implementation based on IObservable and IObserver interfaces.

## Example6
This is a .NET specific implementation based on reactive extensions (Rx).
