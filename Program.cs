Console.WriteLine("Welcome to the employee roster console");
Console.WriteLine("-------------------------------------------");
Console.Write("\nPlease enter the number of employees you wish to enter: ");
int numberOfEmployees = int.Parse(Console.ReadLine());
Console.WriteLine($"Initializing roster for {numberOfEmployees} employees...");
string[] employeeRoster = new string[numberOfEmployees];
for (int i = 0; i < numberOfEmployees; i++)
{
    Console.Write($"Enter the first name of employee {i}: ");
    string name = Console.ReadLine();
    employeeRoster[i] = name;
}
Array.Sort(employeeRoster);
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Current employee roster:");
foreach (string name in employeeRoster)
{
    Console.WriteLine(name);
}