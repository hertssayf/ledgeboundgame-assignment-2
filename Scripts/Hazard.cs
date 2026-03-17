using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        TryHitPlayer(other.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        TryHitPlayer(other.gameObject);
    }

    private void TryHitPlayer(GameObject other)
    {
        PrototypePlayer player = other.GetComponentInParent<PrototypePlayer>();
        if (player != null)
        {
            player.TakeHit();
        }
    }
}
