// Created by: Zaida Hammel
// Created on: April 2022
//
// This program accepts user inputusing System;

using System;

class RandomGenerator 
{
    public static void Main (string[] args) 
    {
        System.Random random = new System.Random();
        // This function determines if your guess is correct.
        System.Console.WriteLine(random.Next(6));

    }
}