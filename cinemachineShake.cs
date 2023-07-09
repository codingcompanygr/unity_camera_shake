using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cinemachineShake : MonoBehaviour
{
    private CinemachineVirtualCamera cvc;
    private CinemachineBasicMultiChannelPerlin cbmcp;
    private float timer;

    private void Awake()
    {
        cvc = GetComponent<CinemachineVirtualCamera>();
    }

    public void CameraShake(float intensity, float time)
    {
        cbmcp.m_AmplitudeGain = intensity;
        timer = time;
    }

    private void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                cbmcp.m_AmplitudeGain = 0f;
            }
        }
    }
}
