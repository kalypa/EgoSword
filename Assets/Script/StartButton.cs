using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour
{
    public AudioClip clip;
    public void OnClickStartButton()
    {
        
        Invoke("StartButton",.3f);
    }

    public void LoadGame()
    {
        SoundManager.instance.SFXPlay("Start", clip);
        SceneManager.LoadScene("Main");
    }

}
