// Create a Dictionary list of employee IDs and the name that goes with the ID.
// Fill in a few records then ask the user for their ID and return their name.


using System.Globalization;

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[1] = "Neven";
employees[2] = "John";
employees[3] = "Tim";
employees[4] = "Yukica";
employees[5] = "Sue";

string idText;
int id;
bool isValid = false;


do
{
    Console.Write("Please enter employee ID: ");
    idText = Console.ReadLine();
    isValid = int.TryParse(idText, out id);
    if (isValid == false)
    {
        Console.WriteLine("Invalid input, please try again.");
    }
    else if (id < 0 || id > employees.Count - 1)
    {
        Console.WriteLine($"Employee with ID number {id} does not exist, please try again.");
        isValid = false;
    }
} while (isValid == false);

Console.WriteLine($"The employee with ID number {id} is: {employees[id]}");