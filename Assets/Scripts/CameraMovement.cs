using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float Sensitivity = 0.5f;

    public int MaxXPos = 8; 
    public int MinXPos = -8; 
    public int MaxZPos = 8; 
    public int MinZPos = -8;

    private bool _isDragging = false;
    private Vector3 _dragOrigin;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            _isDragging = true;
            _dragOrigin = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            _isDragging = false;
        }

        if (_isDragging)
        {
            Vector3 currentPosition = Input.mousePosition;
            Vector3 moveVector = (currentPosition - _dragOrigin) * Sensitivity * Time.deltaTime;

            Vector3 newPosition = transform.position - new Vector3(moveVector.x, 0f, moveVector.y);
            newPosition.x = Mathf.Clamp(newPosition.x, MinXPos, MaxXPos);
            newPosition.z = Mathf.Clamp(newPosition.z, MinZPos, MaxZPos);

            transform.position = newPosition;

            _dragOrigin = currentPosition;
        }
    }



}
