using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 50.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}