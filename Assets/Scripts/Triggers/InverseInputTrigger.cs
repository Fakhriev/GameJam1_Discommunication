using System;
using System.Collections;
using UnityEngine;

public class InverseInputTrigger : CollisionTrigger
{
    [SerializeField] private float _inverseInputEffectTimeInSec = 10f;
    [SerializeField] private bool _destoyAfterCollided = false;
    [SerializeField] private GameObject _model;
    private Collider _collider;
    public static event Action<InputMapState> InputMapChanged;

    private void Awake()
    {
        _collider = gameObject.GetComponent<Collider>();
    }

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        InputMapChanged?.Invoke(InputMapState.Inverse);
        StartCoroutine(NormalizedInputWithDelay());
        if (_destoyAfterCollided)
            Hide();
    }
    private IEnumerator NormalizedInputWithDelay()
    {
        yield return new WaitForSeconds(_inverseInputEffectTimeInSec);
        InputMapChanged?.Invoke(InputMapState.Normal);
        if (_destoyAfterCollided)
            Destroy(gameObject);
    }

    private void Hide()
    {
        _model.SetActive(false);
        _collider.enabled = false;
    }
}