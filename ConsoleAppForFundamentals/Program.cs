using ABC;
using ConsoleAppForFundamentals;
using ConsoleAppForFundamentals.FileIO;
using ConsoleAppForFundamentals.Generics;

// Datatypes
// Numbers: Integers and Floating points

byte? age = 34;
short numberOfPeopeInCompany = 23424;   // Camel casing
int areaOfCountry = 234224424;
long distanceBetweenPlanets = 234223252353;

// Accuracy (Precision)
float averageWeight = 67.5342324242424f;
double averageDistance = 23422.34224242234234224;
decimal averageDistanceBetweenElectrons = 23422.34224242234234224333253m;

// Text
string name = "Bishnu Ji";
char gender = 'M';

// Flags
bool isQA = true;

// Dates
DateTime dob = new(1990, 12, 21);

// Nullables

//Console.WriteLine(averageWeight);

// string userInput = Console.ReadLine();
//Console.WriteLine($"Your entered {userInput.Length} characters");

// Get user name and convert it to uppercase

Person bishnu = new Person("Bishnu Rawal", new DateTime(1990, 12, 12), 79387589373534);
//bishnu.PrintDetails();

Person binisha = new();
binisha.name = "Binisha";
binisha.dob = new DateTime(2000, 12, 12);
binisha.nid = 79387589334535;
//binisha.PrintDetails();

// Create a class called "Page"
// with fields height (inch), width (inch) and title

// "Page" should have parameterized constructor which
// assigns each fields

// Create a method that prints height and width 
// of that page in pixels

// Create instance of this class and display details in console


Student bis = new("Bishnu sdfsafa Singh Yawal", new DateTime(1990, 12, 12), "Ascol", "BIT");
(string AgeString, int AgeDays) = bis.CalculateAge();
var y = bis.GetInitials();

var output = Student.PrintDetails(age: AgeString, initial: y);
var output1 = Student.PrintDetails(age: AgeString, initial: y, ageDays: AgeDays);
//Console.WriteLine(output);
//Console.WriteLine(output1);


// Vehicle vehicle= new Vehicle();
// vehicle.VehicleNumber = "BA PA 3455";
// var x = vehicle.VehicleNumber;

// Modify instantiation process

// EV = number, range, battercapacity
IVehicle car1 = new ElectricVehicle("BA PA 3455", 420, 40.5f);

// Engine = number, mileage, cc
IVehicle car2 = new EngineVehicle("BA PA 1234");

Generics g = new();
//g.PrintDetails<string, int>("abc", 1);

//PlayingWIthCollections.LearnArrays();

//Linq.Query();

var fileHandler = new FileHandler();
var emps = fileHandler.ReadFile();

fileHandler.WriteFile();

fileHandler.WriteEmployeesToFile(emps);
