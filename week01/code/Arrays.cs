using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Creating Variable for new array.
        var results = new double[length];

        // Begin to Iterate through each index of the fixed array to prepare to the new array with correct results.
        for (int i = 0; i < length; i++)
        {
            // Add the resulting final products to our new array that will be returned. 
            // Also performs math calculation.
            results[i] = ((i + 1) * number);
        }

        // Writting out the results to confirm correct.
        Debug.WriteLine(results);

        // Return completed array.
        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Establish variables including length of the array, and a new array that will eventually contain the final result.
        var length = data.Count();
        var newArray = new List<int>();

        // Split the List so that the larger numbers are in one new array and the smaller numbers in a different array. 
        // We will eventually put the largerNumbers in the front and smallerNumbers in the back.
        var largerNumbersArray = data.GetRange(length - amount, amount);
        var smallerNumberArray = data.GetRange(0, length - amount);

        // Iterate through both new arrays and append the larger Numbers FIRST and then the Smaller numbers SECOND
        // Iterating through larger array.
        for (int i = 0; i < largerNumbersArray.Count(); i++)
        {
            newArray.Add(largerNumbersArray[i]);
        };

        // Iterating through smaller array.
        for (int i = 0; i < smallerNumberArray.Count(); i++)
        {
            newArray.Add(smallerNumberArray[i]);
        }

        // Set the original Array's values to the newArray values thus updating the original array.
        for (int i = 0; i < length; i++)
        {
            data[i] = newArray[i];
        }

        // Write out the new data file to demonstrate that the Array is updated correctly
        foreach (int item in data)
        {
            Debug.Write(item);
            Debug.Write(',');
            Debug.Write(' ');
        }

    }
}
