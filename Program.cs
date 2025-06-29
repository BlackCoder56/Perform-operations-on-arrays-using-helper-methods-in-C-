﻿// string[] palletes = ["B14", "A11", "B12", "A13"];

// Sorting Items in the Array
// Console.WriteLine("Sorted...");
// Array.Sort(palletes);
// foreach (var pallete in palletes)
// {
//     Console.WriteLine($"-- {pallete}");
// }

// // Reversing
// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(palletes);
// foreach (var pallet in palletes)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Array.clear()
// Console.WriteLine("");

// Console.WriteLine($"Before: {palletes[0].ToLower()}");  // Printing before Array is cleared
// Array.Clear(palletes, 0, 2); // Here arrays from index 0 and clearing 2 elements
// if (palletes[0] != null)  // Checking where the element to be returned isn't null value
//     Console.WriteLine($"After: {palletes[0].ToLower()}");

// Console.WriteLine($"Clear 2 ... count: {palletes.Length}");
// foreach (var pallete in palletes)  // foreach loop printing the Array items
// {
//     Console.WriteLine($"-- {pallete}");
// }

// Console.WriteLine("");
// Array.Resize(ref palletes, 6); // Calling the Resize method passing `pallets` array by reference using the `ref keyword. Here we resizing from 4 elements to 6
// Console.WriteLine($"Resizing 6 ... count: {palletes.Length}");

// // Adding the two new elements in the array
// palletes[4] = "C01"; 
// palletes[5] = "C02";

// foreach (var pallete in palletes)
// {
//     Console.WriteLine($"-- {pallete}");
// }


// // Use the ToCharArray() to reverse a string
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// Reverse words in a sentence
// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] words = pangram.Split(' '); // here we get a string array with out words as array items

// string[] wordBox = new string[words.Length]; // initialize array to store our reversed words

// for (int i = 0; i < words.Length; i++) // loop through the length of word array
// {
//     char[] letters = words[i].ToCharArray(); // store letters in the word as char array items
//     Array.Reverse(letters); // reverse the letters
//     wordBox[i] = new string(letters); // convert the char array back into a string
// }

// string newPangram = String.Join(" ", wordBox); // convert the array back to string

// Console.WriteLine(newPangram); // print the string on the console

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderArray = orderStream.Split(',');

Array.Sort(orderArray);
foreach (string order in orderArray)
{
    if (order.Length == 4)
    {
        Console.WriteLine(order);
    }
    else
    {
        Console.WriteLine($"{order}      - Error");
    }
}