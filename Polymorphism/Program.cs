// See https://aka.ms/new-console-template for more information
using Polymorphism.Example1;
using Polymorphism.Example2;


ILoan farmerLoan = new FarmerLoan();
ILoan businessLoan = new BusinessLoan();


farmerLoan.Calculate();
businessLoan.Calculate();


Console.WriteLine("---------------------------------");



Ticket sports = new Sports();
sports.GetTicket();
Ticket movie = new Movie();
movie.GetTicket();



Console.WriteLine("---------------------------------");

