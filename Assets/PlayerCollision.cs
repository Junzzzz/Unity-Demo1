using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Obstacle")
        {
            Debug.Log("hit");
        }
    }
}