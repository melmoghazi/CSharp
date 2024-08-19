Class 
is a blueprint of an object that contains variables for storing data and functions to perform operations on the data.
A class will not occupy any memory space; hence, it is only a logical representation of data.

Object
An object is a software bundle of related variables and methods.
An object is an instance of a class.
-----------------------------------------------------------------------------
C# Object Oriented Programming Concepts
1-Abstraction
2-Encapsulation
3-Inheritance
4-Polymorphism

1-Abstraction
Represent the essential feature without representing the background details.
 
Abstraction lets you focus on what the object does instead of how it does it.
Abstraction provides a generalized view of your classes or objects by providing relevant information.
Abstraction is the process of hiding the working style of an object and showing the information about an object understandably.
 
2-Encapsulation
Wrapping up a data member and a method together into a single unit (calss).
 
3-Inheritance
When a class includes a property of another class, it is known as inheritance. Inheritance is a process of object reusability.
 
4-Polymorphism
One name, many forms. One function behaves in different forms. In other words, "Many forms of a single object are called Polymorphism.


Differences between Abstraction and Encapsulation
Abstraction solves the problem at the design level.
Encapsulation solves the problem at the implementation level.
Use an example of a Mobile Phone:
You have a Mobile Phone; you can dial a number using keypad buttons. You don't even know how these are working internally. This is called abstraction. 
You only have the information that is necessary to dial a number. But the not internal working of the mobile. 
But how does the Mobile Phone work internally? How are the keypad buttons connected to the internal circuit? That is called Encapsulation.
-----------------------------------------------------------------------------
Abstract Base Class
There are some important points about Abstract Base Class.
1-An Abstract Base class cannot be instantiated; it means the object of that class cannot be created.
2-The class having the abstract keyword with some of its methods (not all) is known as an Abstract Base Class.
3-The class having the Abstract keyword with all its methods is a pure Abstract Base Class.
4-The method of the abstract class that has no implementation is known as "operation". It can be defined as an abstract void method ();
5-An abstract class holds the methods, but the actual implementation is made in the derived class.
—-------------------------------------------
Why and when should we use an abstract class?
So we would create an abstract class when want to move the common functionality of 2 or more classes 
into a base class and when we don't want that base class to be instantiated.
—-------------------------------------------
Can an abstract class have a constructor? If so, what is the use?
Yes, a class constructor used to initialize the class fields in the same line.
If you want to initialize certain fields of the abstract class before the instantiation of the child-class takes place.
Execute code that is relevant for every child class. This prevents the duplicate code.
—-------------------------------------------
You cannot create an instance of an abstract class,so what is the use of a constructor in an abstract class?
Because we can create an instance of a class that is derived from the abstract class. So when an instance of derived class is created the parent abstract class constructor is automatically called.
So it is a good practice to use the protected access modifier with the abstract class constructor. Public doesn’t make sense.
—-------------------------------------------
Can you call an abstract method from an abstract class constructor?
Yes,if you want the abstract method to be invoked automatically whenever an instance of the class that is derived from the abstract class is created, then we would call it in the constructor of the base class.
—-------------------------------------------
Override vs new when implementing a virtual method?
 - override will override the implementation 
 - new will hide the virtual method in the base class.
Example when use new:
Base b = new Derived();
Derived d = new Derived();
b.Print(); // Calls Base.Print 
d.Print(); // Calls Derived.Print
—-------------------------------------------
What is an interface?
- Interface created using interface keyword
- Interface can contains but with declaration only not implementation:
	- Porperities
	- Methods
	- Delegates
	- Events 
- Interface can not contain fields
- Interface members are public by default, and they don’t allow access modifiers.
- If a class or a struct inherits from an interface, it must provide an implementation for all interface members. Otherwise we get a compile time error.
- A class or a struct can inherit from more than one interface at the same time, but whereas, a class can not inherit from more than one class at the same time.
- Interface can inherit from other interfaces.A class that inherits this interface must provide implementation for all interface members in the entire interface inheritance chain.
- We can not create an instance of an interface, but an interface reference variable can point to a derived class object.
- Interface names naming conventions are prefixed with capital I.
—-------------------------------------------
Interface VS Abstract class?
Abstract class
	- Can have implementation for some of its members(methods)
	- Can have fields
	- Members can have access modifier
	- Can inherit from another abstract class, concrete class, and interface.
Interface
	- Can not have implementation for any of its members
	- Can not have fields
	- Members can not have access modifier
	- Can inherit from another interfaces only
—-------------------------------------------
What are the advantages of using interfaces?
Interfaces allow us to use loosely coupled systems.
Interfaces are very useful for dependency injection.
Interfaces make unit testing and mocking easier.

-----------------------------------------------------------------------------
C# Extension Method
Static method of a static class, where the "this" modifier is applied to the first parameter. 
The type of the first parameter will be the type that is extended.
Allow us to add methods to existing class without:
- Changing its source code, or 
- Creating a new class that inherit from it.
Create the extension methods if you do not have the source code of the class.
Most of the time you will be using the existing extension methods.
Example ist to get number of words from a given string.
Another example are the linq extension methods.
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
Resources:
https://www.c-sharpcorner.com/UploadFile/mkagrahari/introduction-to-object-oriented-programming-concepts-in-C-Sharp/
https://www.c-sharpcorner.com/uploadfile/4624e9/abstraction-in-C-Sharp/