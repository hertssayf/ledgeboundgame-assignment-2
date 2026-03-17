using UnityEngine;

public class GoalFlag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PrototypePlayer player = other.GetComponentInParent<PrototypePlayer>();
        if (player != null && PrototypeGameManager.Instance != null)
        {
            PrototypeGameManager.Instance.LevelComplete();
        }
    }
}
