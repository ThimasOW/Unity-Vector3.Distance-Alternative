# Vector3.Distance-Alternative
Use this extension method for agents in your scene, if you have no need for the exact distance between your agent and the objective, but still need to know if it is in range.

This is not a replacement for the Distance method, but an alternative. Vector3.Distance is a great method for retrieving the 
exact distance between targets, but most of the time this information is not neccessarily required for 
the functionality of the methods it is used in. 

Example:
![image](https://user-images.githubusercontent.com/79156616/209559243-33a2eb02-158b-45c5-95d2-2ea8aecdc07f.png)

In this example we need this platypus to know when it is in range of the plant for it to begin eating it. 
The easy and common method for this would be to check the distance between these gameObjects using Vector3.Distance.
This solution works, but it is very bad for performance. Vector3.Distance utilizes the square roots of the Vectors
and although square roots are not as expensive to use now as they have been, we can do better.

Using this extension method in an if statement instead, we can check if is in range or has reached its destination 
using the integrated Unity methods of the Navigation.AI namespace. This way we are only using the information that
the agent already updates to be able to function on its own, subsequently makes our Update loop much more performant. 

As this is an extension method, you can use it on your NavMeshAgent reference, as seen in the Example.cs file.
