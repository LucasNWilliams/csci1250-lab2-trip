// Part 1 //

int tripTotalMiles;
double milesPerGallon;
decimal pricePerGallon;

// Get variable values
Console.WriteLine("\nHow many miles is the round trip?");
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

int totalPeople;
int totalPizza;
decimal pricePerPizza;
const int SLICES_PER_PIZZA = 8;

// Ask more questions
Console.WriteLine("\nHow many people are going?");
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

int weeklyHoursWorked;
decimal hourlyRate;
const decimal TAX_RATE = .18M;

// Ask even more questions
Console.WriteLine("\nHow many hours did you work this week?");
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




// Extra line to separate instances in terminal
Console.WriteLine();