using UnityEngine;

public class RotatorObject : MonoBehaviour
{
    [SerializeField] private float _rotationAngle;

    public float GetRotationAngle()
    {
        return _rotationAngle;
    }
}
