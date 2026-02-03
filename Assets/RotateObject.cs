using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Transform sun;
    public float rotationSpeed = 50f;
    public float orbitSpeed = 20f;

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}

