# Welcome to ObserverDemo !

> **Reminder** (wikipedia def) : observer pattern is a software design pattern in which an object, called the *subject*, maintains a list of its dependents, called *observers*, and notifies them automatically of any state changes, usually by calling one of their methods.

Here are 6 different implementations of observer design pattern. Each implementation is illustrated through an example.
Each example contains 2 projects : a class library and a console application.

The use case consists of notifing observers of any change in subject state property.

**Technical requirements** : .NET 4.6.1, VS 17 

## Example1
This is the most basic implementation. It can be easily translated into any other programming language.

>Subject is aware of observers (maintains a collection of observers and iterate over them when state change in order to call update operation).

>Observer is aware of subject (maintains a reference on subject that will be used to get its state when update operation is called)

Drawbacks : 
- The notification of state changes is made explicitly by the subject.
- Strong coupling betweeen Subject and Observer.

## Example2


## Example3
## Example4
## Example5
## Example6
