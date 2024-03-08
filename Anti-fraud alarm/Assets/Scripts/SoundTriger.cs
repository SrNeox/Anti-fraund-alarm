using UnityEngine;

public class SoundTriger : MonoBehaviour
{
    [SerializeField] private Signaling _signaling;

    private bool _playerInside;

    private void OnTriggerEnter(Collider other)
    {
        _playerInside = true;
        _signaling.Launch(_playerInside);
    }

    private void OnTriggerExit(Collider other)
    {
        _playerInside = false;
        _signaling.Launch(_playerInside);
    }
}
