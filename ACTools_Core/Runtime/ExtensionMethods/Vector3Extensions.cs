using UnityEngine;

public static class Vector3Extensions
{
    /// <summary> Checks the all the values to see if they're equal. </summary>
    /// <param name="original"> This Vector3. </param>
    /// <returns> Returns true if all values are equal. </returns>
    public static bool AreAllValuesEqual(this Vector3 original)
    {
        return original.x == original.y && original.x == original.z;
    }

    /// <summary> Finds the normalized direction from this Vector3 to a given Vector3. </summary>
    /// <param name="original"> This Vector3. </param>
    /// <param name="destination"> The Vector3 to be compared to this for the direction. </param>
    /// <returns> The normalized Vector3 of the direction to the target. </returns>
    public static Vector3 DirectionTo(this Vector3 original, Vector3 destination)
    {
        return Vector3.Normalize(destination - original);
    }

    /// <summary> Sets the X value of this Vector3 to 0. </summary>
    /// <param name="original"> This Vector2. </param>
    public static void FlatX(this ref Vector3 original)
    {
        original = new Vector3(0f, original.y, original.z);
    }

    /// <summary> Sets the Y value of this Vector3 to 0. </summary>
    /// <param name="original"> This Vector3. </param>
    public static void FlatY(this ref Vector3 original)
    {
        original = new Vector3(original.x, 0f, original.z);
    }

    /// <summary> Sets the Z value of this Vector3 to 0. </summary>
    /// <param name="original"> This Vector3. </param>
    public static void FlatZ(this ref Vector3 original)
    {
        original = new Vector3(original.x, original.y, 0f);
    }
    
    /// <summary> Checks to see if this Vector3 is between two other Vector3s along all 3 axes. </summary>
    /// <param name="original"> This Vector3. </param>
    /// <param name="bottomLeftBack"> One of the Vector3s to compare to this. </param>
    /// <param name="topRightFront"> The other Vector3 to compare to this. </param>
    /// <returns> Returns true if this Vector3 is between. </returns>
    public static bool IsBetween(this Vector3 original, Vector3 bottomLeftBack, Vector3 topRightFront)
    {
        return ((bottomLeftBack.x < original.x && original.x < topRightFront.x) &&
                (bottomLeftBack.y < original.y && original.y < topRightFront.y) &&
                (bottomLeftBack.z < original.z && original.y < topRightFront.z));
    }

    /// <summary> Replaces the current values of this Vector3 with any given values. </summary>
    /// <param name="original"> This Vector3. </param>
    /// <param name="x"> The value to replace this Vector2.x, if any. </param>
    /// <param name="y"> The value to replace this Vector2.y, if any. </param>
    /// <param name="z"> The value to replace this Vector2.z, if any. </param>
    public static void With(this ref Vector3 original, float? x = null, float? y = null, float? z = null)
    {
        original = new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
    }
}