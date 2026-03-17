using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PrototypePlayer : MonoBehaviour
{
    [Header("Respawn")]
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float deathY = -10f;
    [SerializeField] private float hitCooldown = 0.75f;

    private Rigidbody2D rb;
    private bool canBeHit = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (PrototypeGameManager.Instance == null || PrototypeGameManager.Instance.GameEnded)
            return;

        if (transform.position.y < deathY)
        {
            TakeHit();
        }
    }

    public void TakeHit()
    {
        if (!canBeHit || PrototypeGameManager.Instance == null)
            return;

        canBeHit = false;
        PrototypeGameManager.Instance.PlayerHit(this);
        StartCoroutine(ResetHitCooldown());
    }

    public void Respawn()
    {
        rb.linearVelocity = Vector2.zero;

        if (spawnPoint != null)
        {
            transform.position = spawnPoint.position;
        }
    }

    public void SetSpawnPoint(Transform newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
    }

    private IEnumerator ResetHitCooldown()
    {
        yield return new WaitForSeconds(hitCooldown);
        canBeHit = true;
    }
}
