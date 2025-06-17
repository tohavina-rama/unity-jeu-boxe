using UnityEngine;

public class LockArmPosition : MonoBehaviour
{
    private Vector3 initialLocalPosition;

    void Start()
    {
        // Sauvegarde la position locale au départ
        initialLocalPosition = transform.localPosition;
    }

    void LateUpdate()
    {
        // Garde la position initiale sur Y et Z, mais laisse X suivre la caméra (si besoin)
        transform.localPosition = new Vector3(
            transform.localPosition.x,
            initialLocalPosition.y,
            initialLocalPosition.z
        );
    }
}
