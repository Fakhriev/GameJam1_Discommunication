using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private EquipItem targetEquipItem;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float openZRotaion;
    [SerializeField] private float closedZRotaion;

    private float _targetZRotation;
    private bool _isRotating;

    private void Start()
    {
        SetClosedState();
        targetEquipItem.OnEquiped += SetOpenState;
        targetEquipItem.OnUnEquiped += SetClosedState;
    }

    private void SetOpenState()
    {
        _targetZRotation = openZRotaion;
        _isRotating = true;
    }

    private void SetClosedState()
    {
        _targetZRotation = closedZRotaion;
        _isRotating = true;
    }

    private void Update()
    {
        if (_isRotating == false)
            return;

        float currentZRotation = transform.eulerAngles.z;
        currentZRotation = Mathf.MoveTowards(currentZRotation, _targetZRotation, rotationSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentZRotation);

        if (currentZRotation == _targetZRotation)
            _isRotating = false;
    }

    private void OnDestroy()
    {
        targetEquipItem.OnEquiped -= SetOpenState;
        targetEquipItem.OnUnEquiped -= SetClosedState;
    }
}