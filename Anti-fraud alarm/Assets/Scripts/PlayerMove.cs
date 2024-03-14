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
        float inputY = Input.GetAxis("Horizontal");

        transform.Rotate(_rotationSpeed * inputY * Time.deltaTime * Vector3.up);
    }

    private void Locomotion()
    {
        float inputX = Input.GetAxis("Vertical");

        transform.Translate(inputX * _moveSpeed * Time.deltaTime * Vector3.forward);
    }
}
