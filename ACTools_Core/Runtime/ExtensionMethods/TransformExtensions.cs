using UnityEngine;

public static class TransformExtensions
{
    /// <summary> Finds the normalized direction from this Transform to a given Transform. </summary>
    /// <param name="original"> This Transform. </param>
    /// <param name="destination"> The Transform to be compared to this for the direction. </param>
    /// <returns> Returns the normalized Vector3 of the direction to the target. </returns>
    public static Vector3 DirectionTo(this Transform original, Transform destination)
    {
        return original.position.DirectionTo(destination.position);
    }

    /// <summary> Checks to see if this Transform is between two other Transforms along all 3 axes. </summary>
    /// <param name="original"> This Transform. </param>
    /// <param name="bottomLeftBack"> One of the Transforms to compare to this. </param>
    /// <param name="topRightFront"> The other Transform to compare to this. </param>
    /// <returns> Returns true if this Transform is between the other two. </returns>
    public static bool IsBetween(this Transform original, Transform bottomLeftBack, Transform topRightFront)
    {
        return original.position.IsBetween(bottomLeftBack.position, topRightFront.position);
    }
}