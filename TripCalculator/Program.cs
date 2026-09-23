// Part 1
int tripTotalMiles;
double milesPerGallon;
decimal pricePerGallon;

// Get variable values
Console.WriteLine("How many miles is the round trip?");
tripTotalMiles = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the miles per gallon of the car?");
milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the price per gallon?");
pricePerGallon = Convert.ToInt32(Console.ReadLine());

// Calculate fuel costs
double gallonsNeeded = tripTotalMiles / milesPerGallon;
decimal fuelCost = (decimal)gallonsNeeded * pricePerGallon;

// Tell user the gallons needed and the cost
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2") + "(9.29)");
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C") + "($26.84)");

