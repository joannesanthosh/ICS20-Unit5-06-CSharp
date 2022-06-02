// Created by: Joanne Santhosh
// Created on: May 2022
//
// This program multiplies numbers using loops

using System;

class Program
{
    public static void Main(string[] args)
    {

        int firstInteger;
        int secondInteger;
        var addedNumber = 0;
        var result = 0;

        // input
        Console.Write("This program multiplies numbers using loops");
        Console.WriteLine("");
        Console.Write("Enter the first integer: ");
        firstInteger = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        secondInteger = Convert.ToInt32(Console.ReadLine());
      
        // process
    if (firstInteger > 0 && secondInteger > 0) {
      while (addedNumber < secondInteger) {
        addedNumber = addedNumber + 1;
        result = result + firstInteger;
      }
    } else if (firstInteger < 0 && secondInteger < 0) {
      while (addedNumber > secondInteger) {
        addedNumber = addedNumber - 1;
        result = result - firstInteger;
      }
    } else if (firstInteger > 0 && secondInteger < 0) {
        while (addedNumber > secondInteger) {
        addedNumber = addedNumber - 1;
        result = result - firstInteger;
      }
    } else if (firstInteger < 0 && secondInteger > 0) {
        while (addedNumber < secondInteger) {
        addedNumber = addedNumber + 1;
        result = result + firstInteger;
      }
    }
        Console.WriteLine("The answer is: " + firstInteger + " x " + addedNumber + " = " + result);
    }
}