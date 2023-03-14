using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject swordButton;

    public AudioClip clip;
    public bool On = false;

    public void OnButtonEvent()
    {
        
        if (On == false)
        {
            swordButton.SetActive(true);
            SoundManager.instance.SFXPlay("Shop", clip);
            On = true;
        }
        else if (On == true)
        {
            swordButton.SetActive(false);
            SoundManager.instance.SFXPlay("Exit", clip);
            On = false;
        }
        
    }

}
