using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed = 5f;
    [SerializeField] private float _sideSpeed = 5f;
    [SerializeField] private Rigidbody _rb;
    public bool canMove = false;

    private float _horizontal;

    private void Update()
    {
        if (!canMove)
        {
            return;
        }
        else
        {
            Move();
        }
    }

    private void Move()
    {
        _horizontal = Input.GetAxis("Horizontal");

        Vector3 forwardMove = _forwardSpeed * Time.deltaTime * transform.forward;

        Vector3 sideMove = _horizontal * _sideSpeed * Time.deltaTime * transform.right;

        _rb.MovePosition(_rb.position + forwardMove + sideMove);
    }
}