using UnityEngine;

public class FistHitbox : MonoBehaviour
{
public bool isPunching = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isPunching && other.CompareTag("PunchingBall"))
        {
            Debug.Log("touché");
            other.GetComponent<PunchingBall>().ReactToHit(transform.position);
           // other.GetComponent<BoxBall>().ReactToHit(transform.position);

        }
    }
}
