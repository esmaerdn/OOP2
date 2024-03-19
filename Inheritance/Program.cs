// See https://aka.ms/new-console-template for more information
using Inheritance.Example1;
using Inheritance.Example2;
using Inheritance.Example3;


Student student = new Student();
student.Id = 1;
student.FirstName = "Büşra";
student.LastName = "Konyar";
student.Status = true;
student.Department = "Computer Science";
student.GPA = 2.88;

Instructor instructor = new Instructor();
instructor.Id = 2;
instructor.FirstName = "Muhammed";
instructor.LastName = "Inan";
instructor.Status = false;
instructor.Title = "Instructor";
instructor.Branch = "Computer Science";

Console.WriteLine("Instructor info: \n" + instructor.Id + " \n" + instructor.FirstName + " \n" + instructor.LastName + " \n" + instructor.Status + " \n" + instructor.Title + " \n" + instructor.Branch);
Console.WriteLine("---------------------");
Console.WriteLine("Studets info:  \n" + student.Id + " \n" + student.FirstName + " \n" + student.LastName + " \n" + student.Status + " \n" + student.Department + " \n" + student.GPA);
//////////////////////////////////////////////////
Car car = new Car();
car.Id = 1;
car.TopSpeed = 250;
car.WheelNumber = 4;
car.TrunkVolume = 55.60;

Bus bus = new Bus();
bus.Id = 2;
bus.TopSpeed = 150;
bus.WheelNumber = 6;
bus.PassengerCapacity = 40;
///////////////////////////////////
Person person = new Person();
person.FirstName = "Çelik";
person.LastName = "Erdem";
person.FullName = person.FirstName + " " + person.LastName;

Personnel personnel = new Personnel();
personnel.FirstName = "Aytunç";
personnel.LastName = "Alptekin";
personnel.FullName = personnel.FirstName + " " + personnel.LastName;
personnel.WorkHour = 8;
personnel.Salary = 17000;

SalesConsultant salesConsultant = new SalesConsultant();
salesConsultant.Bonus = 1000;

Console.WriteLine("---------------------");
Console.WriteLine("Personel Bilgileri: ");
Console.WriteLine("Tam Ad: " + personnel.FullName);
Console.WriteLine("Çalışma Saati: " + personnel.WorkHour);
Console.WriteLine("Maaş: " + personnel.Salary);
Console.WriteLine("Prim: " + salesConsultant.Bonus);






