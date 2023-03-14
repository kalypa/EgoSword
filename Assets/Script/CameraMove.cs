using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private Camera MainCamera;
    [SerializeField]
    private Camera SubCamera;
    [SerializeField]
    private GameObject button;

    private bool boolMainCameraOn = false;

    private SwordRevolution swordRevolution;

    public AudioClip clip;
    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private Canvas lobbyCanvas;
    void Awake()
    {
        MainCameraOn();

    }


    private void MainCameraOn()
    {
        SubCamera.enabled = false;
        MainCamera.enabled = true;
        canvas.gameObject.SetActive(true);
        lobbyCanvas.gameObject.SetActive(false);
    }
    public void SubCameraOn()
    {
        
        MainCamera.enabled = false;
        SubCamera.enabled = true;
        canvas.gameObject.SetActive(false);
        lobbyCanvas.gameObject.SetActive(true);
    }
    public void ExchangeCameraOn()
    {
        boolMainCameraOn = !boolMainCameraOn;
        if (boolMainCameraOn)
        {
            MainCameraOn();
            SoundManager.instance.SFXPlay("Main", clip);
        }
        else
        {
            SubCameraOn();
            SoundManager.instance.SFXPlay("Lobby", clip);

        }
    }
   
    
}
