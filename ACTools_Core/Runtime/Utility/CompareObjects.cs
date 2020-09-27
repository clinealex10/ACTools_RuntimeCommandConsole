using UnityEngine;

public static class CompareObjects
{
    /// <summary> Compares two objects based on their names. </summary>
    /// <typeparam name="T"> The types of objects being compared. </typeparam>
    /// <param name="x"> One of the objects to be compared. </param>
    /// <param name="y"> The other object to be compared. </param>
    /// <returns> Returns zero if they are equal, a negative number if x precedes y, a positive number if x comes after y. </returns>
    public static int ByName<T>(T x, T y) where T : Object
    {
        if (x == null)  // If one or both values are null.
        {
            if (y == null)
                return 0;
            else
                return 1;
        }
        else if (y == null)
            return -1;


        char[] xChar = x.name.ToCharArray();    // Converts both names of the objects for comparison.
        char[] yChar = y.name.ToCharArray();

        int loopLength = xChar.Length <= yChar.Length ? xChar.Length : yChar.Length;    // Gets the smaller of the to char arrays.

        // Compares achievements based on each char, return if one comes before the other.
        for (int index = 0; index < loopLength; index++)
        {
            int comparisonValue = xChar[index].CompareTo(yChar[index]);

            if (comparisonValue != 0)
                return comparisonValue;
        }

        if (xChar.Length < yChar.Length)    // Compares achievements based on the length of each char array. 
            return -1;
        else if (xChar.Length > yChar.Length)
            return 1;
        else
            return 0;
    }
}