using UnityEngine;

public class SoundActivator : TriggerObserver
{
    [SerializeField] private AudioClip audioClip;

    protected override void OnTriggerActivated()
    {
        SoundManager.Instance.PlaySound(audioClip);
    }
}
