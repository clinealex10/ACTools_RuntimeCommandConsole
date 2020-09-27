using UnityEngine;

public static class Vector2Extensions
{
    /// <summary> Checks the all the values to see if they're equal. </summary>
    /// <param name="original"> This Vector2. </param>
    /// <returns> Returns true if all values are equal. </returns>
    public static bool AreAllValuesEqual(this Vector2 original)
    {
        return original.x == original.y;
    }

    /// <summary> Finds the normalized direction from this Vector2 to a given Vector2. </summary>
    /// <param name="original"> This Vector2. </param>
    /// <param name="destination"> The Vector2 to be compared to this for the direction. </param>
    /// <returns> Returns the normalized Vector2 of the direction to the target. </returns>
    public static Vector2 DirectionTo(this Vector2 original, Vector2 destination)
    {
        return (destination - original).normalized;
    }

    /// <summary> Sets the X value of this Vector2 to 0. </summary>
    /// <param name="original"> This Vector2. </param>
    public static void FlatX(this ref Vector2 original)
    {
        original = new Vector2(0f, original.y);
    }

    /// <summary> Sets the Y value of this Vector2 to 0. </summary>
    /// <param name="original"> This Vector2. </param>
    public static void FlatY(this ref Vector2 original)
    {
        original = new Vector2(original.x, 0f);
    }

    /// <summary> Checks to see if this Vector2 is between two other Vector2s along both axes. </summary>
    /// <param name="original"> This Vector2. </param>
    /// <param name="bottomLeft"> One of the Vector2 to compare to this. </param>
    /// <param name="topRight"> The other Vector2 to compare to this. </param>
    /// <returns> Returns true if this Vector2 is between the other two. </returns>
    public static bool IsBetween(this Vector2 original, Vector2 bottomLeft, Vector2 topRight)
    {
        return ((bottomLeft.x < original.x && original.x < topRight.x) &&
                (bottomLeft.y < original.y && original.y < topRight.y));
    }

    /// <summary> Replaces the current values of this Vector2 with any given values. </summary>
    /// <param name="original"> This Vector2. </param>
    /// <param name="x"> The value to replace this Vector2.x, if any. </param>
    /// <param name="y"> The value to replace this Vector2.y, if any. </param>
    public static void With(this ref Vector2 original, float? x = null, float? y = null)
    {
        original = new Vector2(x ?? original.x, y ?? original.y);
    }
}