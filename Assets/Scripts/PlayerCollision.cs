using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            // 关闭脚本
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}