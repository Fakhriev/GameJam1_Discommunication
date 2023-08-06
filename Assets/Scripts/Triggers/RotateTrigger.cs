using UnityEngine;

public class RotateTrigger : CollisionTrigger
{
    [SerializeField] private string observeTag;
    [SerializeField] private float rotationSpeed = 1f;

    private Transform _targetTransorm;
    private Quaternion _defaultRotation;

    private void Start()
    {
        _defaultRotation = transform.rotation;
    }

    private void Update()
    {
        Quaternion targetRotation = (_targetTransorm == null) ? _defaultRotation : GetRotationToTargetTransform();
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    private Quaternion GetRotationToTargetTransform()
    {
        Vector3 direction = _targetTransorm.position - transform.position;
        return Quaternion.LookRotation(direction);
    }

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        _targetTransorm = playerHibox.Player.transform;
    }

    protected override void OnPlayerUncollided(PlayerHibox playerHibox)
    {
        _targetTransorm = null;
    }
}