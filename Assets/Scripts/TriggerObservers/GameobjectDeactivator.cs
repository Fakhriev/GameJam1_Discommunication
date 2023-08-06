using UnityEngine;

public class GameobjectDeactivator : TriggerObserver
{
    [SerializeField] private GameObject deactivateObject;

    protected override void OnTriggerActivated()
    {
        deactivateObject.SetActive(false);
    }
}