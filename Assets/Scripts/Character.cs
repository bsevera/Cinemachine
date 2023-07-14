using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private CharacterController _controller;

    [SerializeField]
    private float _moveSpeed;

    [SerializeField]
    private float _rotateSpeed;
    private Vector3 _direction;

    //[SerializeField]
    //private CinemachineVirtualCamera[] _virtualCamera;

    // Update is called once per frame
    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");
        _direction = new Vector3(0, 0, _vertical);
        _direction *= _moveSpeed * Time.deltaTime;
        _controller.Move(_direction);

        Vector3 rotation = new Vector3(0, _horizontal * _rotateSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);

        //if (Input.GetMouseButtonDown(1))
        //{
        //    _virtualCamera[0].gameObject.SetActive(false);
        //    _virtualCamera[1].gameObject.SetActive(true);
        //}
        //else if (Input.GetMouseButtonUp(1))
        //{
        //    _virtualCamera[0].gameObject.SetActive(true);
        //    _virtualCamera[1].gameObject.SetActive(false);

        //}
    }
}
