using UnityEngine.AI;

internal static class NavigationHelpers
{
    /// <summary>
    /// Checks the current path of the NavMeshAgent. 
    /// </summary>
    /// <param name="agent"></param>
    /// <returns>True if destination is reached, false if not</returns>
    public static bool ReachedDestination(this NavMeshAgent agent)
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= 2)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
