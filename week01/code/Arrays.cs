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
        // Check length is positive and more than 0
        if (length <= 0) return [0];

        // Initialize the answer array
        var res = new double[length];

        // We loop through the length
        for (int i = 1; i <= length; i++)
        {
            // Multiply and add the number into the array
            res[i - 1] = i * number;
        }

        // Return array
        return res;
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
        // Check that this function is worth running
        if (amount <= 0 || amount == data.Count) return;

        // Get the index where it will split
        int splitIndex = data.Count - amount;

        // Get the back of the array
        List<int> back = data.GetRange(splitIndex, amount);

        // Remove the end
        data.RemoveRange(splitIndex, amount);

        // Insert the back into the beginning
        data.InsertRange(0, back);
    }
}
