// See https://aka.ms/new-console-template for more information
using ProjectAnimes.Domain.Entities.Users;

Console.WriteLine("Hello, World!");

var user = new UsersEntity
(
    name: "Rick", 
    email: "email@teste.com", 
    password: "123inv", 
    dateOfBirth: new DateTime(1997, 10, 26)
);

//user.Name = "o";

Console.ReadLine();
