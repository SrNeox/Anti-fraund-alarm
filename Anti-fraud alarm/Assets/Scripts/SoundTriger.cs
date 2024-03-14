using UnityEngine;

public class SoundTriger : MonoBehaviour
{
    [SerializeField] private Signaling _signaling;

    private void OnTriggerEnter(Collider other)
    {
        _signaling.Launch(1);
    }

    private void OnTriggerExit(Collider other)
    {
        _signaling.Launch(0);
    }
}
