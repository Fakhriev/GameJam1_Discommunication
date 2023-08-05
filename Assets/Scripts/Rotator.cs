using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private float _rotation;

    private void Start()
    {
        _rotation = transform.eulerAngles.y;
    }

    private void Update()
    {
        _rotation += rotationSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0f, _rotation, 0f);
    }
}