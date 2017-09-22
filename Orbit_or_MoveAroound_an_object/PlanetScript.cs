using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour {

    private float _timer = 0;
    private float _angle = 0;
    public float _speed = 0.02f;
    public float radius = 2;

    private Vector3 rotationAngles;
    private float rotationSpeed;

    public GameObject Center;

    void Start() {
    }

    void Update() {
        MoveCircle();
    }

    void MoveCircle() {
        _timer += (Time.deltaTime) * _speed;
        _angle = _timer;

        transform.position = Vector3.MoveTowards(transform.position, new Vector3((Center.transform.position.x + Mathf.Sin(_angle) * radius), Center.transform.position.y, ((Center.transform.position.z + Mathf.Cos(_angle) * radius))), 0.35f);
        transform.Rotate(new Vector3(rotationAngles.x * rotationSpeed * Time.deltaTime, rotationAngles.y * rotationSpeed * Time.deltaTime, rotationAngles.z * rotationSpeed * Time.deltaTime));
    }
}
