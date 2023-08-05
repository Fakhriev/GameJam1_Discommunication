using UnityEngine;

public class ParticleActivator : TriggerObserver
{
    [SerializeField] private new ParticleSystem particleSystem;

    protected override void OnTriggerActivated()
    {
        particleSystem.gameObject.SetActive(true);
        particleSystem.Play();
    }
}