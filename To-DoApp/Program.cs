// See https://aka.ms/new-console-template for more information

using System;
using System.Reflection;

var todos = new List<string>();



Console.WriteLine("Hello");
Console.WriteLine("What Do you wants to do?");

bool shalexist = false;

while (!shalexist)
{
    Console.WriteLine();
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    var userchoice = Console.ReadLine();
    switch (userchoice)
    {
        case "E":
        case "e":
            Console.WriteLine("Exit");
            shalexist = true;
            Console.ReadLine();
            break;
        case "S":
        case "s":
            ShowAllToDoes();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodos();
            break;
        default:
            Console.WriteLine("Invalid choice");
            Console.ReadKey();
            break;
    }
}

void ShowAllToDoes()
{
    if (todos.Count == 0)
    {
        ShowTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {

        Console.WriteLine($"{i + 1}.{todos[i]}");
    }


}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter The TODO description");
        description = Console.ReadLine();
    }
    while (!IsDescriptionValid(description));
    todos.Add(description);
}



void RemoveTodos()
{
    if (todos.Count == 0)
    {
        ShowTodosMessage();
        return;
    }
    int index;
    do
    {
        Console.WriteLine("Select the index of the TODOS you want to remove");
        ShowAllToDoes();
    }
    while (!TryReadIndex(out index));
    RemoveTodosAtIndex(index-1);


}

void RemoveTodosAtIndex(int index)
{
    
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}

bool TryReadIndex(out int index)
{
    var userinput = Console.ReadLine();
    if (userinput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty");
        return false;

    }
    if (int.TryParse(userinput, out index) && index >= 1 && index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid");
    return false;

}

static void ShowTodosMessage()
{
    Console.WriteLine("No TODOS Have been Added yet");
}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The Description cannot be empty");
        return false;
    }
    else if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }
    return true;
}


//Console.ReadKey();
