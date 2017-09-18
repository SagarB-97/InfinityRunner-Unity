using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        GM.instance.LoseLife();
    }
}