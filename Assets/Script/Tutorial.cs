using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public AudioClip clip;
    [SerializeField]
    private GameObject tutorialTab = null;
  public void OnCLickTutorialButton()
    {
        SoundManager.instance.SFXPlay("Tutorial", clip);
        tutorialTab.SetActive(true);
        
    }
    public void OnCLickExitButton()
    {
        SoundManager.instance.SFXPlay("Tutorial", clip);
        tutorialTab.SetActive(false);
    }
}
