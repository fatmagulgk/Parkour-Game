using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : Singleton<CameraController>
{
    public CinemachineVirtualCamera menuKamera;
    public CinemachineVirtualCamera oyunKamera;

    void Start()
    {
        // Oyuna baþlarken menü kamerasý öncelikli olsun
        menuKamera.Priority = 10;
        oyunKamera.Priority = 5;
    }

    public void StartButtonActive()
    {
        // Oyun kamerasýný öncelikli yap, menü kamerasýný geri plana at
        menuKamera.Priority = 5;
        oyunKamera.Priority = 10;
    }
}
