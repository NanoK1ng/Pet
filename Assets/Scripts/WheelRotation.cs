using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{

    public float rotationSpeed = 10f;

    private bool isPetInside = false;

    public string TargetTag = "Pet";


    private void Update()
    {
        if (isPetInside)
        {

            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TargetTag))
        {
            isPetInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(TargetTag))
        {
            isPetInside = false;
        }
    }

}
