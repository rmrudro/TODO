// See https://aka.ms/new-console-template for more information

//var person = new Person("Juthi", 1992);




using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coding.Exercise
{
    public static class NumberToDayOfWeekTranslator
    {
        static string Translate(int value)
        {
            switch(value) {
                case 1:
                    return "Monday";
                    break;
                case 2:
                    return "Tuesday";
                    break;
                case 3:
                    return "Wednesday";
                    break;
                case 4:
                    return "Thrusday";
                    break;
                case 5:
                    return "Friday";
                    break;
                case 6:
                    return "Saturday";
                    break;
                case 7:
                    return "Sunday";
                    break;
                default:
                    return "Invalid day of the week";
                    break;

                }
            }

        }
        //your code goes here
    }



    var person = new Person
{
    Name = "Rifat",
    YearOfBirth = 1981
};


class Person
{
    public string Name { get; init; }

    public int YearOfBirth { get; init; }

    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}


}
