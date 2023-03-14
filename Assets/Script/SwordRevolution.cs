using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRevolution : MonoBehaviour
{
    [SerializeField]
    private GameObject fireSword = null;
    [SerializeField]
    private GameObject fireSword2 = null;
    [SerializeField]
    private GameObject fireSword3 = null;
    [SerializeField]
    private GameObject waterSword = null;
    [SerializeField]
    private GameObject waterSword2 = null;
    [SerializeField]
    private GameObject waterSword3 = null;
    [SerializeField]
    private GameObject windSword = null;
    [SerializeField]
    private GameObject windSword2 = null;
    [SerializeField]
    private GameObject windSword3 = null;
    [SerializeField]
    private GameObject lightSword = null;
    [SerializeField]
    private GameObject lightSword2 = null;
    [SerializeField]
    private GameObject lightSword3 = null;
    [SerializeField]
    private GameObject darkSword = null;
    [SerializeField]
    private GameObject darkSword2 = null;
    [SerializeField]
    private GameObject darkSword3 = null;

    public void AllLevel()
    {
        FireLevel1();
        WaterLevel1();
        WindLevel1();
        LightLevel1();
        DarkLevel1();
        FireLevel10();
        WaterLevel10();
        WindLevel10();
        LightLevel10();
        DarkLevel10();
        FireLevel50();
        WaterLevel50();
        WindLevel50();
        LightLevel50();
        DarkLevel50();
    }
    public void FireLevel1()

    {
        if (GameManager.Instance.CurrentUser.attributeList[0].SwordNumber == 0)
        {

            if (GameManager.Instance.CurrentUser.attributeList[0].Level >= 1)
            {
                fireSword.SetActive(true);
            }
        }
    }
    public void WaterLevel1()
    {
        if (GameManager.Instance.CurrentUser.attributeList[1].SwordNumber == 1)
        {
            if (GameManager.Instance.CurrentUser.attributeList[1].Level >= 1)
            {
                waterSword.SetActive(true);
            }
        }
    }
    public void WindLevel1()
    {
        if (GameManager.Instance.CurrentUser.attributeList[2].SwordNumber == 2) 
        {
            if (GameManager.Instance.CurrentUser.attributeList[2].Level >= 1)
            {
                windSword.SetActive(true);
            }
        }
    }
    public void LightLevel1()
    {
        if (GameManager.Instance.CurrentUser.attributeList[3].SwordNumber == 3)
        {
            if (GameManager.Instance.CurrentUser.attributeList[3].Level >= 1)
            {
                lightSword.SetActive(true);
            }
        }
    }
    public void DarkLevel1()
    {
        if (GameManager.Instance.CurrentUser.attributeList[4].SwordNumber == 4)
        {
            if(GameManager.Instance.CurrentUser.attributeList[4].Level >=1)
            darkSword.SetActive(true);
        }
    }
    public void FireLevel10()
    {
        if (GameManager.Instance.CurrentUser.attributeList[0].SwordNumber == 0) 
        {
            if (GameManager.Instance.CurrentUser.attributeList[0].Level >= 9)
            {
                fireSword.SetActive(false);
                fireSword2.SetActive(true);
            }
        }
    }
    public void WaterLevel10()
    {
        if (GameManager.Instance.CurrentUser.attributeList[1].SwordNumber == 1) 
        {
            if (GameManager.Instance.CurrentUser.attributeList[1].Level >= 9)
            {
                waterSword.SetActive(false);
                waterSword2.SetActive(true);
            }
        }
    }
    public void WindLevel10()
    {
        if (GameManager.Instance.CurrentUser.attributeList[2].SwordNumber == 2)
        {
            if (GameManager.Instance.CurrentUser.attributeList[2].Level >= 9)
            {
                windSword.SetActive(false);
                windSword2.SetActive(true);
            }
        }
    }
    public void LightLevel10()
    {
        if (GameManager.Instance.CurrentUser.attributeList[3].SwordNumber == 3)
        {
            if (GameManager.Instance.CurrentUser.attributeList[3].Level >= 10)
            {
                lightSword.SetActive(false);
                lightSword2.SetActive(true);
            }
        }
    }
    public void DarkLevel10()
    {
        if (GameManager.Instance.CurrentUser.attributeList[4].SwordNumber == 4)
        {
            if (GameManager.Instance.CurrentUser.attributeList[4].Level >= 10)
            {
                darkSword.SetActive(false);
                darkSword2.SetActive(true);
            }
        }
    }
    public void FireLevel50()
    {
        if (GameManager.Instance.CurrentUser.attributeList[0].SwordNumber == 0)
        {
            if (GameManager.Instance.CurrentUser.attributeList[0].Level >= 50)
            {
                fireSword2.SetActive(false);
                fireSword3.SetActive(true);
            }
        }
    }
    public void WaterLevel50()
    {
        if (GameManager.Instance.CurrentUser.attributeList[1].SwordNumber == 1)
        {
            if (GameManager.Instance.CurrentUser.attributeList[1].Level >= 50)
            {
                waterSword2.SetActive(false);
                waterSword3.SetActive(true);
            }
        }
    }
    public void WindLevel50()
    {
        if (GameManager.Instance.CurrentUser.attributeList[2].SwordNumber == 0)
        {
            if (GameManager.Instance.CurrentUser.attributeList[2].Level >= 50)
            {
                windSword2.SetActive(false);
                windSword3.SetActive(true);
            }
        }
    }
    public void LightLevel50()
    {
        if (GameManager.Instance.CurrentUser.attributeList[3].SwordNumber == 3)
        {
            if (GameManager.Instance.CurrentUser.attributeList[3].Level >= 50)
            {

                lightSword2.SetActive(false);
                lightSword3.SetActive(true);
            }
        }
    }
    public void DarkLevel50()
    {
        if (GameManager.Instance.CurrentUser.attributeList[4].SwordNumber == 4)
        {
            if (GameManager.Instance.CurrentUser.attributeList[4].Level >= 50)
            {
                darkSword2.SetActive(false);
                darkSword3.SetActive(true);
            }
        }
    }
}
