using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Example : MonoBehaviour
{
  NavMeshAgent agent;
  
  void Avake()
  {
    if (agent == null)
      agent = GetComponent<NavMeshAgent>();
  }
  
  void Start() 
  {
    StartCoroutine(MoveWhenReachedDestination());
  }
  
  Ienumerator MoveWhenReachedDestination()
  {
    WaitforSeconds wait = new WaitForSeconds(5f);
    
    while (true)
    {
      yield return wait;
      
      if (agent.ReachedDestination)
        //Move somewhere else
    }
  }
}
