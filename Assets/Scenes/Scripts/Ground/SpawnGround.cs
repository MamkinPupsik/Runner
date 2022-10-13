using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    [SerializeField] private GameObject _ground;
    [SerializeField] private Transform _spawnPosition;
    private void Start()
    {
        _spawnPosition = GetComponent<Transform>();
    }
    void Update()
    {
        for (; true ;)
        {
            Instantiate(_ground, _spawnPosition.position, Quaternion.identity);
        }
                
        
    }
}
