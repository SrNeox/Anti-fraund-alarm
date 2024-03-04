using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;

    private bool _playerInside;
    private float _maxVolume = 1;
    private float _minVolum = 0;
    private float _increaseRate = 0.1f;
    private float _decreaseRate = 0.1f;

    private void OnTriggerEnter(Collider other)
    {
        _playerInside = true;
        StartCoroutine(IncreaseVolume());
    }

    private void OnTriggerExit(Collider other)
    {
        _playerInside = false;
        StartCoroutine(DecreaseVolume());
    }

    private IEnumerator IncreaseVolume()
    {
        while (_playerInside == true)
        {
            _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, _maxVolume, _increaseRate * Time.deltaTime);

            yield return null;
        }
    }

    private IEnumerator DecreaseVolume()
    {
        while (_playerInside == false)
        {
            _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, _minVolum, _decreaseRate * Time.deltaTime);

            yield return null;
        }
    }
}
