using UnityEngine;

public class GameobjectActivator : TriggerObserver
{
    [SerializeField] private GameObject activateObject;

    protected override void OnTriggerActivated()
    {
        activateObject.SetActive(true);
    }
}