using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private PlayerMovement _playerMovement;

    public void CanPlay()
    {
        _playerMovement.canMove = true;

        _button.gameObject.SetActive(false);
    }
}
