using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwitchCameraViews : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera[] _virtualCamera;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _virtualCamera[0].gameObject.SetActive(false);
            _virtualCamera[1].gameObject.SetActive(true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            _virtualCamera[0].gameObject.SetActive(true);
            _virtualCamera[1].gameObject.SetActive(false);

        }

    }
}
