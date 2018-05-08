# HabiticaNET
Interact with the Habitica API using C# in a .NET standard library!

## What is it?
HabiticaNET is an SDK for interacting with the Habitica game's Web API.

**In its current state it's not entirely complete. It's an ongoing project, however for right now it just will allow you to log in to Habitica and pull user data or even create new user accounts**

## How to install?
The library will be hosted in a nuget package when I achieve a respectable 0.1.0-alpha release.

## How to use?
In you project you can call into any method in the Habitica class, such as...

``` cs
using HabiticaNET;

public void Login()
{
    HttpResponse response = Habitica.Login("myUsername", "myPassword");
}

public void RegisterNewUser() 
{
    HttpResponse response = Habitica.RegisterNewUser("myUsername", "myPassword", "myEmail");
}
```

## How to contribute
If you find any errors or want a certain feature don't hesitate to create an issue. And if you see an issue and want to take a stab at it by all means submit a PR so I can take a look at it.