using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform leftPoint;
    [SerializeField] private Transform rightPoint;
    [SerializeField] private float moveSpeed = 2f;

    private Transform currentTarget;

    private void Start()
    {
        if (rightPoint != null)
            currentTarget = rightPoint;
    }

    private void Update()
    {
        if (leftPoint == null || rightPoint == null || currentTarget == null)
            return;

        transform.position = Vector2.MoveTowards(
            transform.position,
            currentTarget.position,
            moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, currentTarget.position) < 0.05f)
        {
            currentTarget = currentTarget == rightPoint ? leftPoint : rightPoint;
            Flip();
        }
    }

    private void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1f;
        transform.localScale = scale;
    }
}
