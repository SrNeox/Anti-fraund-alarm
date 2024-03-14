using System.Collections;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourse;

    private float _rate—hange = 0.1f;
    private Coroutine _variationVolume;

    public void Launch(float maxVolum)
    {
        if(_variationVolume != null)
        {
            StopCoroutine(_variationVolume);
        }

        _variationVolume = StartCoroutine(VariationVolume(maxVolum));
    }

    private IEnumerator VariationVolume(float maxVolum)
    {
        while (true)
        {
            ChangesVolume(maxVolum, _rate—hange);

            if (_audioSourse.volume == 0)
            {
                _audioSourse.enabled = false;
            }
            else
            {
                _audioSourse.enabled = true;
            }

            yield return null;
        }
    }

    private void ChangesVolume(float value, float rate—hange)
    {
        _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, value, rate—hange * Time.deltaTime);
    }
}
