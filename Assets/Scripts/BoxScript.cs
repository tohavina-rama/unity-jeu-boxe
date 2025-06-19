using UnityEngine;



public class BoxBall : MonoBehaviour
{
   
    public void ReactToHit(Vector3 hitFrom)
    {
       
        Debug.Log("La box a été frappé !");
  
        Vector3 direction = transform.position - hitFrom;
    direction.y = 0; 
    direction.Normalize();

  
    Quaternion lookRotation = Quaternion.LookRotation(direction);
    transform.rotation = lookRotation;
    Debug.Log("Rotation effectué !");

    }
}
