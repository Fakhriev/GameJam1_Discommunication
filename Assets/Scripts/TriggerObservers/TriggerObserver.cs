using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerObserver : MonoBehaviour
{
    [SerializeField] private CollisionTrigger trigger;

    private void Start()
    {
        trigger.OnTriggered += OnTriggerActivated;
    }

    private void OnDestroy()
    {
        trigger.OnTriggered -= OnTriggerActivated;
    }

    protected abstract void OnTriggerActivated();
}