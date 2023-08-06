using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Foods")]
    [SerializeField] GameObject[] _foodPrefabs;

    [Header("X Position")]
    [SerializeField] private Transform minimalXTransform;
    [SerializeField] private Transform maximalXTransform;

    [Header("Z Position")]
    [SerializeField] private Transform minimalZTransform;
    [SerializeField] private Transform maximalZTransform;

    [Header("Spawn Parametres")]
    [SerializeField] private float _spawnPosY = 10;
    [SerializeField] private float _startDelay = 1;
    [SerializeField] private float _spawnInterval = 1;

    void Start()
    {
        InvokeRepeating("SpawnFood",_startDelay,_spawnInterval);
    }

    public void SpawnFood()
    {
        int foodIndex = Random.Range(0, _foodPrefabs.Length);
        float xPosition = Random.Range(minimalXTransform.position.x, maximalXTransform.position.x);
        float zPosition = Random.Range(minimalZTransform.position.z, maximalZTransform.position.z);

        Vector3 spawnPos = new Vector3(xPosition, _spawnPosY, zPosition);
        Instantiate(_foodPrefabs[foodIndex], spawnPos, _foodPrefabs[foodIndex].transform.rotation);
    }
}
