using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] _foodPrefabs;

    [SerializeField] private float _spawnPosY = 10;
    [SerializeField] private float _spawnPosX = 50;
    [SerializeField] private float _startDelay = 1;
    [SerializeField] private float _spawnInterval = 1;

    void Start()
    {
        InvokeRepeating("SpawnFood",_startDelay,_spawnInterval);
    }

    void Update()
    {
       
    }

    public void SpawnFood()
    {
        int foodIndex = Random.Range(0, _foodPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(0, _spawnPosX), _spawnPosY, 0);
        Instantiate(_foodPrefabs[foodIndex], spawnPos, _foodPrefabs[foodIndex].transform.rotation);
    }
}
