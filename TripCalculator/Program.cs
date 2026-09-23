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

// Get variable values
Console.WriteLine("How many miles is the round trip?");
tripTotalMiles = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the miles per gallon of the car?");
milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the price per gallon?");
pricePerGallon = Convert.ToDecimal(Console.ReadLine());

// Calculate fuel costs
double gallonsNeeded = tripTotalMiles / milesPerGallon;
decimal fuelCost = (decimal)gallonsNeeded * pricePerGallon;

// Tell user the gallons needed and the cost
Console.WriteLine("\nGallons Needed: " + gallonsNeeded.ToString("F2") + "(9.29)");
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C") + "($26.84)");


// Part 2 //
Console.WriteLine("\n=== Part 2: Pizza Party ===");

// Starting variables for part 2
const int SLICES_PER_PIZZA = 8;
int totalPeople;
int totalPizza;
decimal pricePerPizza;

// Ask more questions
Console.WriteLine("How many people are going?");
totalPeople = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many pizzas are you ordering?");
totalPizza = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the price of a pizza?");
pricePerPizza = Convert.ToDecimal(Console.ReadLine());

// Calculate values
int totalSlices = totalPizza * SLICES_PER_PIZZA;
double slicesPerPerson = (double)totalSlices / totalPeople;
decimal pizzaCost = totalPizza * pricePerPizza;

// Tell user the results
Console.WriteLine("\nTotal Slices: " + totalSlices + "(24)");
Console.WriteLine("Slices per Person: " + slicesPerPerson.ToString("F1") + "(4.8)");
Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C") + "($38.97)");


// Part 3 //
Console.WriteLine("\n=== Part 3: Paycheck ===");

// Starting variables for part 3
const decimal TAX_RATE = .18M;
int weeklyHoursWorked;
decimal hourlyRate;

// Ask even more questions
Console.WriteLine("How many hours did you work this week?");
weeklyHoursWorked = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your hourly rate?");
hourlyRate = Convert.ToDecimal(Console.ReadLine());

// Calculate more stuff
decimal grossPay = weeklyHoursWorked * hourlyRate;
decimal taxWithheld = grossPay * TAX_RATE;
decimal takeHomePay = grossPay - taxWithheld;

// Tell the user the values that we just calculated
Console.WriteLine("\nGross Pay: " + grossPay.ToString("C") + "($297.00)");
Console.WriteLine("Tax Withheld: " + taxWithheld.ToString("C") + "($53.46)");
Console.WriteLine("Take-home Pay: " + takeHomePay.ToString("C") + "($243.54)");


// Part 4 //
Console.WriteLine("\n=== Part 4: The Whole Trip ===");

// Calculate final values
decimal tripTotal = fuelCost + pizzaCost;
decimal costPerPerson = tripTotal / totalPeople;
decimal takeHomePayPerHour = takeHomePay / weeklyHoursWorked;
double hoursOfWorkNeeded = (double)(costPerPerson / takeHomePayPerHour);

// Give the final values
Console.WriteLine("Trip total: " + tripTotal.ToString("C") + "($65.81)");
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C") + "($13.16)");
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C") + "($11.07)");
Console.WriteLine("Hours you must work to cover your share: " + hoursOfWorkNeeded.ToString("F2") + "(1.19)");


// Extra line to separate instances in terminal
Console.WriteLine();