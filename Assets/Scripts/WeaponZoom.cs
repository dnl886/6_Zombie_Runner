using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomeOutFov = 60f;
    [SerializeField] float zoomedInFov = 20f;

    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;

    RigidbodyFirstPersonController fpsController;
    [SerializeField] float mouseSensitivity = 5;

    bool zoomeInToggle = false;

    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if(zoomeInToggle == false)
            {
                zoomeInToggle = true;
                fpsCamera.fieldOfView = zoomedInFov;
                fpsController.mouseLook.XSensitivity = zoomInSensitivity;
                fpsController.mouseLook.YSensitivity = zoomInSensitivity;
            }
            else
            {
                zoomeInToggle = false;
                fpsCamera.fieldOfView = zoomeOutFov;
                fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
                fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
            }
        }
    }

    
}
