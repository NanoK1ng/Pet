using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera MainCamera;
    public Camera PetCamera;

    private bool _isPetCameraActive = false;

    private void Start()
    {
 
        MainCamera.enabled = true;
        PetCamera.enabled = false;
    }

    public void SwitchCamera()
    {
        _isPetCameraActive = !_isPetCameraActive;

        MainCamera.enabled = !_isPetCameraActive;
        PetCamera.enabled = _isPetCameraActive;

    }
}
