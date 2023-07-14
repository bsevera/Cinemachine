using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Challenge : MonoBehaviour
{
    [SerializeField]
    private GameObject _sphere;

    [SerializeField]
    private GameObject _cube;

    private CinemachineVirtualCamera _camera;

    private float _defaultZoomValue = 60f;
    private float _zoomValue = 60f;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<CinemachineVirtualCamera>();
        _camera.m_Lens.FieldOfView = _defaultZoomValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R Key pressed");
            if (_camera.LookAt.gameObject == _cube)
                _camera.LookAt = _sphere.transform;
            else
                _camera.LookAt = _cube.gameObject.transform;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _zoomValue -= 20f;

            if (_zoomValue < 20f)
                _zoomValue = _defaultZoomValue;

            _camera.m_Lens.FieldOfView = _zoomValue;

            Debug.Log("FieldOfView = " + _camera.m_Lens.FieldOfView.ToString());
        }
    }
}