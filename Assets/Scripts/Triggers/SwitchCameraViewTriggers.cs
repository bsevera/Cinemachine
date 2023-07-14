using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwitchCameraViewTriggers : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera[] _virtualCamera;

    private void OnTriggerEnter(Collider other)
    {
        int cameraIndex = 0;

        switch (other.gameObject.transform.name)
        {
            case "Trigger1":
                cameraIndex = 1;
                break;
            case "Trigger2":
                cameraIndex = 2;
                break;
            case "Trigger3":
                cameraIndex = 3;
                break;
            default: 
                cameraIndex = 0;
                break;
        }

        SetActiveCamera(cameraIndex);

    }

    private void SetActiveCamera(int cameraIndex)
    {        
        foreach (var cam in _virtualCamera)
        {            
            if (Array.IndexOf(_virtualCamera, cam) == cameraIndex)
            {
                cam.Priority = 30;
            }
            else
            {
                cam.Priority = 5;
            }
        }
    }
}
