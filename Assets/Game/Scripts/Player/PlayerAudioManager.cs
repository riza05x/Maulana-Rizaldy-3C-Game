using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeraudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _footstepSFX;

    [SerializeField]
    private AudioSource _landingSFX;

    [SerializeField]
    private AudioSource _punchSFX;

    [SerializeField]
    private AudioSource _glideSFX;

    public void PlayGlideSFX()
    {
        _glideSFX.Play();
    }

    public void StopGlideSFX()
    {
        _glideSFX.Stop();
    }

    private void PlayFootsetpSFX()
    {
        _footstepSFX.volume = Random.Range(0.8f, 1f);
        _footstepSFX.pitch = Random.Range(0.8f, 1.5f);
        _footstepSFX.Play();
    }

    private void PlayLandingSFX()
    {
        _landingSFX.Play();
    }

    private void PlayPunchSFX()
    {
        _punchSFX.volume = Random.Range(0.8f, 1f);
        _punchSFX.pitch = Random.Range(0.8f, 1.5f);
        _punchSFX.Play();
    }
}
