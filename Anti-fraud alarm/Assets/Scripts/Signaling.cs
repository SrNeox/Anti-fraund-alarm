using System.Collections;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;

    private bool _playerInside;

    public void Launch(bool playerInside)
    {
        _playerInside = playerInside;
        StartCoroutine(SelectingChangesVolume());
    }

    private IEnumerator SelectingChangesVolume()
    {
        float maxVolum = 1;
        float minVolum = 0;
        float rate—hange = 0.1f;

        while (true)
        {
            if (_playerInside == true)
            {
                ChangesVolume(maxVolum, rate—hange);
            }
            else
            {
                ChangesVolume(minVolum, rate—hange);
            }

            yield return null;
        }
    }

    private void ChangesVolume(float value , float rate—hange)
    {

        _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, value, rate—hange * Time.deltaTime);
    }    
}
