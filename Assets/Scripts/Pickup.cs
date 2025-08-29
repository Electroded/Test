using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Item>(out var item))
        {
            if (_wallet != null)
            {
                _wallet.ChangeMoney(item.cost);

                Destroy(item.gameObject);
            }
        }
    }
}
