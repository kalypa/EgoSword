using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameObject EndButton;
    public bool On = false;
    public AudioClip clip;

    public void OnButtonEvent()
    {
        if (On == false)
        {
            SoundManager.instance.SFXPlay("End", clip);
            EndButton.SetActive(true);
            On = true;
        }
        else if (On == true)
        {
            SoundManager.instance.SFXPlay("EndCancel", clip);
            EndButton.SetActive(false);
            On = false;
        }
    }


}
