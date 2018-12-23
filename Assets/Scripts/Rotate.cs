using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform origin;
    public float revolutionSpeed;
    public int rotationSpeed;
    public float rx, ry, rz;

    void Start()
    {
        //origin = transform.parent.gameObject.transform;
        rx = 0;
        ry = 1;
        rz = 0;
    }

    void Update()
    {
        Vector3 axis = new Vector3(rx, ry, rz);
        this.transform.RotateAround(origin.position, axis, revolutionSpeed * Time.deltaTime);
        this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
