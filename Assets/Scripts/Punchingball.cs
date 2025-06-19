/*using UnityEngine;

public class PunchingBall : MonoBehaviour
{
// public Transform rotatingChild;  // Ton enfant (Armature ou Box)
private Animator animator;

void Start()
{
    animator = GetComponent<Animator>();  // Animator sur le parent
}

public void ReactToHit(Vector3 hitFrom)
{
   /* Vector3 direction = transform.position - hitFrom;
    direction.y = 0;
    direction.Normalize();

    Quaternion lookRotation = Quaternion.LookRotation(direction);
    Vector3 euler = lookRotation.eulerAngles;

    Vector3 localEuler = rotatingChild.localEulerAngles;
    localEuler.y = euler.y;  // modifie juste Y
    rotatingChild.localEulerAngles = localEuler;

    animator.SetTrigger("bend");
}
}*/


using UnityEngine;

public class PunchingBall : MonoBehaviour
{

private Animator animator;

void Start()
{
    animator = GetComponent<Animator>();  
}

public void ReactToHit(Vector3 hitFrom)
{
    Vector3 direction = transform.position - hitFrom;
    direction.y = 0;  // ignore la hauteur
    direction.Normalize();

    Quaternion lookRotation = Quaternion.LookRotation(direction);
    Vector3 euler = lookRotation.eulerAngles;
    transform.rotation = Quaternion.Euler(0, euler.y, 0);  // rotation uniquement sur Y

    animator.SetTrigger("bend");
}
}