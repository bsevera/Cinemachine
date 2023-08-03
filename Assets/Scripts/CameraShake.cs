using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    private CinemachineImpulseSource _source;

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<CinemachineImpulseSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShakeCamera();
        }
    }

    private void ShakeCamera()
    {
        _source.GenerateImpulse();
    }
}
