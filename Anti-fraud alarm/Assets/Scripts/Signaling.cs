using System;
using System.Collections;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;

    private bool _playerInside;

    public void Launch(bool playerInside)
    {
        _playerInside = playerInside;
        StartCoroutine(ChangeVolume());
    }

    private IEnumerator ChangeVolume()
    {
        float maxVolume = 1;
        float minVolum = 0;
        float increaseRate = 0.1f;
        float decreaseRate = 0.1f;

        while (true)
        {
            if (_playerInside == true)
            {
                _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, maxVolume, increaseRate * Time.deltaTime);
            }
            else
            {
                _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, minVolum, decreaseRate * Time.deltaTime);
            }

            yield return null;
        }
    }
}
