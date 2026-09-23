/*
 * Name:        Lucas Williams
 * Course:      CSCI 1250, Section 002
 * Assignment:  Lab 02, Trip Calculator
 * Date:        September 23, 2026
 * Description: Calculates the fuel, food, and work hours behind one road trip.
 */

// Part 1 //
Console.WriteLine("\n=== Part 1: Road Trip ===");

// Starting variables for part 1
int tripTotalMiles;
double milesPerGallon;
decimal pricePerGallon;

// Get values about the trip itself
Console.Write("How many miles is the round trip?        ");
tripTotalMiles = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car? ");
milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the price per gallon?            ");
pricePerGallon = Convert.ToDecimal(Console.ReadLine());

// Calculate fuel needs and costs
double gallonsNeeded = tripTotalMiles / milesPerGallon;
decimal fuelCost = (decimal)gallonsNeeded * pricePerGallon;

// Tell user the gallons needed and the cost
Console.WriteLine("\nGallons Needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost:      " + fuelCost.ToString("C"));


// Part 2 //
Console.WriteLine("\n=== Part 2: Pizza Party ===");

// Starting variables for part 2
const int SLICES_PER_PIZZA = 8;
int totalPeople;
int totalPizza;
decimal pricePerPizza;

// Get information about attendence and pizza quantity and price
Console.Write("How many people are going?        ");
totalPeople = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas are you ordering? ");
totalPizza = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price of a pizza?     ");
pricePerPizza = Convert.ToDecimal(Console.ReadLine());

// Calculate costs for pizza and distribution to each attendee
int totalSlices = totalPizza * SLICES_PER_PIZZA;
double slicesPerPerson = (double)totalSlices / totalPeople;
decimal pizzaCost = totalPizza * pricePerPizza;

// Tell user the results
Console.WriteLine("\nTotal Slices:      " + totalSlices);
Console.WriteLine("Slices per Person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza Cost:        " + pizzaCost.ToString("C"));


// Part 3 //
Console.WriteLine("\n=== Part 3: Paycheck ===");

// Starting variables for part 3
const decimal TAX_RATE = 0.18M;
int weeklyHoursWorked;
decimal hourlyRate;

// Ask hours worked and hourly rate
Console.Write("How many hours did you work this week? ");
weeklyHoursWorked = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your hourly rate?              ");
hourlyRate = Convert.ToDecimal(Console.ReadLine());

// Calculate gross and net pay with taxes
decimal grossPay = weeklyHoursWorked * hourlyRate;
decimal taxWithheld = grossPay * TAX_RATE;
decimal takeHomePay = grossPay - taxWithheld;

// Tell the user their gross and net earnings and their taxes for their work for the week
Console.WriteLine("\nGross Pay:     " + grossPay.ToString("C"));
Console.WriteLine("Tax Withheld:  " + taxWithheld.ToString("C"));
Console.WriteLine("Take-home Pay: " + takeHomePay.ToString("C"));


// Part 4 //
Console.WriteLine("\n=== Part 4: The Whole Trip ===");

// Calculate finals costs and information for the trip
decimal tripTotal = fuelCost + pizzaCost;
decimal costPerPerson = tripTotal / totalPeople;
decimal takeHomePayPerHour = takeHomePay / weeklyHoursWorked;
double hoursOfWorkNeeded = (double)(costPerPerson / takeHomePayPerHour);

// Tell the user the final cost for the trip and individual, as well as hours of work needed to pay for the trip
Console.WriteLine("Trip total:                              " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person:                         " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour:                  " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursOfWorkNeeded.ToString("F2"));


// Extra line to separate instances in terminal
Console.WriteLine();