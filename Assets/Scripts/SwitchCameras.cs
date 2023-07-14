using UnityEngine;
using Cinemachine;

public class SwitchCameras : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera[] _virtualCamera;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Right Arrow Key Pressed");
            _virtualCamera[0].gameObject.SetActive(false);
        }

        if ((Input.GetKeyDown(KeyCode.T)) && (_virtualCamera[1].gameObject.activeInHierarchy == true))
        {
            Debug.Log("Left Arrow Key Pressed");
            _virtualCamera[1].gameObject.SetActive(false);
        }
    }
}
