using UnityEngine;

public class MaterialOffsetChanger : MonoBehaviour
{
    [SerializeField] private Vector2 offsetChangeSpeed;
    [SerializeField] private MeshRenderer meshRenderer;

    private Vector2 _currentOffset;

    private void Start()
    {
        _currentOffset = meshRenderer.material.mainTextureOffset;
    }

    private void Update()
    {
        _currentOffset += offsetChangeSpeed * Time.deltaTime;
        meshRenderer.material.mainTextureOffset = _currentOffset;
    }
}