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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create an array with the size specified by length.
        double[] multiples = new double[length];

        // 2. Use a loop to go through each position in the array.
        for (int i = 0; i < length; i++)
        {
            // 3. Calculate the multiple by multiplying number by i + 1.
            // 4. Store the result in the current position of the array.
            multiples[i] = number * (i + 1);
        }

        // 5. Return the array containing all the multiples.
        return multiples;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // 1. Find the index where the list should be split.
        int splitIndex = data.Count - amount;

        // 2. Get the items from the split index to the end of the list.
        List<int> rightPart = data.GetRange(splitIndex, amount);

        // 3. Get the items from the beginning of the list to the split index.
        List<int> leftPart = data.GetRange(0, splitIndex);

        // 4. Clear the original list.
        data.Clear();

        // 5. Add the right part to the original list first.
        data.AddRange(rightPart);

        // 6. Add the left part after the right part.
        data.AddRange(leftPart);
    }
}
