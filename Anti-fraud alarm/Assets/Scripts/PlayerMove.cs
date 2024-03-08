using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Rotate();
        Locomotion();
    }

    private void Rotate()
    {
        float rotation = Input.GetAxis("Horizontal");

        transform.Rotate(_rotationSpeed * rotation * Time.deltaTime * Vector3.up);
    }

    private void Locomotion()
    {
        float distance = Input.GetAxis("Vertical");

        transform.Translate(distance * _moveSpeed * Time.deltaTime * Vector3.forward);
    }
}
