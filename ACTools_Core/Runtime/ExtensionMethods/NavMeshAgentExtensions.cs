using UnityEngine;
using UnityEngine.AI;

public static class NavMeshAgentExtensions
{
    /// <summary> Gets the NavMeshPath from this agent to a given point without setting the NavMeshPath of this NavMeshAgent. </summary>
    /// <param name="original"> This NavMeshAgent. </param>
    /// <param name="endPosition"> Where the path ends. </param>
    /// <param name="passableMask"> A bitfield mask specifying which NavMesh areas can be passed when calculating a path. </param>
    /// <returns> Returns the path from one point to another if it was created. If it wasn't created, this will return null. </returns>
    public static NavMeshPath GetPathTo(this NavMeshAgent original, Vector3 endPosition, int passableMask)
    {
        return original.path.GetPathTo(original.transform.position, endPosition, passableMask);
    }
}