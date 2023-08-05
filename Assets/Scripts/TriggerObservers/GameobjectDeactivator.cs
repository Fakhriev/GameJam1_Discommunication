using UnityEngine;

public class GameobjectDeactivator : TriggerObserver
{
    [SerializeField] private GameObject activateObject;

    protected override void OnTriggerActivated()
    {
        activateObject.SetActive(false);
    }
}