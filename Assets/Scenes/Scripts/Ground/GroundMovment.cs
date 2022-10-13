using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovment : MonoBehaviour
{
    [SerializeField] private float _speed = 0.9f;
    private Transform _transform;
    void Start() {
        _transform = GetComponent<Transform>();
    }
    void Update() {
        _transform.Translate(Vector3.back * _speed * Time.deltaTime);
    }
}
