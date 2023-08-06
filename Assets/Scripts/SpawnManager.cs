using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] _foodPrefabs;

    [SerializeField] private Transform minimalXTransform;
    [SerializeField] private Transform maximalXTransform;

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
        Vector3 spawnPos = new Vector3(xPosition, _spawnPosY, 0);
        Instantiate(_foodPrefabs[foodIndex], spawnPos, _foodPrefabs[foodIndex].transform.rotation);
    }
}
