using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerMovement>(out var playerMovement))
        {
            playerMovement.canMove = false;
        }
    }
}
