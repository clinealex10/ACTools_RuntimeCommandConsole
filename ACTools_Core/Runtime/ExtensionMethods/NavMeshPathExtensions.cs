using UnityEngine;
using UnityEngine.AI;

// https://forum.unity.com/threads/getting-the-distance-in-nav-mesh.315846/
public static class NavMeshPathExtensions
{
    /// <summary> Gets the length of this path. </summary>
    /// <param name="path"> This path. </param>
    /// <returns> Returns the length of the path. </returns>
    public static float GetPathLength(this NavMeshPath path)
    {
        float pathLength = 0.0f;

        if ((path.status != NavMeshPathStatus.PathInvalid) && (path.corners.Length > 1))
        {
            for (int index = 0; index < path.corners.Length - 1; index++)
            {
                pathLength += Vector3.Distance(path.corners[index], path.corners[index + 1]);
            }
        }

        return pathLength;
    }

    /// <summary> Gets the length of this path. </summary>
    /// <param name="path"> This path. </param>
    /// <param name="drawDeBugPath"> Should this path be drawn using DeBug.DrawLine? </param>
    /// <returns> Returns the length of the path. </returns>
    public static float GetPathLength(this NavMeshPath path, bool drawDeBugPath)
    {
        float pathLength = 0.0f;

        if ((path.status != NavMeshPathStatus.PathInvalid) && (path.corners.Length > 1))
        {
            for (int index = 0; index < path.corners.Length - 1; index++)
            {
                pathLength += Vector3.Distance(path.corners[index], path.corners[index + 1]);
                if (drawDeBugPath)
                    Debug.DrawLine(path.corners[index], path.corners[index + 1], Color.red);
            }
        }

        return pathLength;
    }

    /// <summary> Gets the NavMeshPath from one given point to a second given point without setting this NavMeshPath. </summary>
    /// <param name="original"> This NavMeshPath. </param>
    /// <param name="startPosition"> Where the path begins. </param>
    /// <param name="endPosition"> Where the path ends. </param>
    /// <param name="passableMask"> A bitfield mask specifying which NavMesh areas can be passed when calculating a path. </param>
    /// <returns> Returns the path from one point to another if it was created. If it wasn't created, this will return null. </returns>
    public static NavMeshPath GetPathTo(this NavMeshPath original, Vector3 startPosition, Vector3 endPosition, int passableMask)
    {
        NavMeshPath returnPath = new NavMeshPath();

        if (NavMesh.CalculatePath(startPosition, endPosition, passableMask, returnPath))
            return returnPath;

        return null;
    }

    /// <summary> Sets this NavMeshPath for a path from one given point to a second given point. </summary>
    /// <param name="original"> This NavMeshPath. </param>
    /// <param name="startPosition"> Where the path begins. </param>
    /// <param name="endPosition"> Where the path ends. </param>
    /// <param name="passableMask"> A bitfield mask specifying which NavMesh areas can be passed when calculating a path. </param>
    /// <returns> Returns true if the path is created. </returns>
    public static bool SetPathTo(this NavMeshPath original, Vector3 startPosition, Vector3 endPosition, int passableMask)
    {
        original.ClearCorners();

        return NavMesh.CalculatePath(startPosition, endPosition, passableMask, original);
    }
}