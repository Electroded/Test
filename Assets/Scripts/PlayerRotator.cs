using System.Collections;
using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    [SerializeField] private float _duration;

    private float _rotationAngle; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<RotatorObject>(out var rotatorObject))
        {
            _rotationAngle = rotatorObject.GetRotationAngle();

            StartCoroutine(SmoothRotate(_rotationAngle));
        }
    }

    private IEnumerator SmoothRotate(float angle)
    {
        Quaternion startRotation = transform.rotation;

        Quaternion endRotation = startRotation * Quaternion.Euler(0, angle, 0);

        float elapsed = 0f;

        while (elapsed < _duration)
        {
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, elapsed / _duration);

            elapsed += Time.deltaTime;

            yield return null;
        }
    }
}
