using System.Globalization;

Console.WriteLine("-------------------------------------------");
Console.WriteLine("| Welcome to the employee roster console  |");
Console.WriteLine("-------------------------------------------");
Console.Write("Please enter the number of employees you wish to enter: ");
int numberOfEmployees = int.Parse(Console.ReadLine());
Console.WriteLine($"Initializing roster for {numberOfEmployees} employees...");
string[] employeeRoster = new string[numberOfEmployees];
Console.Clear();
menuSelection();

void menuSelection()
{
    while (true)
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("|    Menu Selection     |");
        Console.WriteLine("-------------------------");
        Console.WriteLine("1: Add an employee");
        Console.WriteLine("2: Show all employees");
        Console.WriteLine("Q: Exit");
        Console.Write("\nPlease enter the corresponding number to the action you would like to perform or 'q' to exit: ");
        string menuSelectionPrompt = Console.ReadLine();
        switch (menuSelectionPrompt.Trim().ToLower())
        {
            case "1":
                Console.Write("\nEnter first name: ");
                string firstName = Console.ReadLine();
                addEmployee(firstName);
                break;
            case "2":
                showEmployees();
                break;
            case "q":
                return;
                break;
            default:
                Console.WriteLine("Incorrect input. Please use the corresponding number to the action (ex: '1' to add an employee) or 'q' to exit.");
                break;
        }
    }
}

void addEmployee(string firstName)
{
    for (int i = 0; i < numberOfEmployees; i++)
    {
        if(employeeRoster[i] == null)
        {
            employeeRoster[i] = firstName;
            return;
        }
    }
    if(employeeRoster.Contains(firstName) == false)
    {
        Console.WriteLine("!!!  ERROR  !!!");
        Console.WriteLine($"Roster capacity is full with {numberOfEmployees} unable to add {firstName}");
        return;
    }
}

void showEmployees()
{
    Array.Sort(employeeRoster);
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Current employee roster:");
    foreach (string name in employeeRoster)
    {
        Console.WriteLine(name);
    }
}
