using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text jewelText = null;
    [SerializeField]
    private Text attributejewelText = null;
    [SerializeField]
    private Animator pickaxeAnimator = null;
    [SerializeField]
    private GameObject upgradePanelTemplate = null;
    [SerializeField]
    private GameObject swordShopTemplate = null;
    [SerializeField]
    private JewelText jewelTextTemplate = null;
    [SerializeField]
    private SwordRevolution swordRevolution = null;

    private List<UpgradePanel> upgradePanelList = new List<UpgradePanel>();
    private List<SwordShop> swordshopList = new List<SwordShop>();
    public AudioClip clip;
    void Start()
    {
        UpdateJewelPanel();

        UpdateattributeJewelPanel();

        CreateShops();

        CreatePanels();

        swordRevolution.AllLevel();

    }
    private void CreatePanels()
    {
        GameObject newPanel = null;
        UpgradePanel newPanelComponent = null;
        foreach (Pickaxe pickaxe in GameManager.Instance.CurrentUser.pickaxeList)
        {
            newPanel = Instantiate(upgradePanelTemplate, upgradePanelTemplate.transform.parent);
            newPanelComponent = newPanel.GetComponent<UpgradePanel>();
            newPanelComponent.SetValue(pickaxe);
            newPanel.SetActive(true);

            upgradePanelList.Add(newPanelComponent);

        }



    }


    private void CreateShops()
    {
        GameObject newShop = null;
        SwordShop newShopComponent = null;
        foreach (Attribute attribute in GameManager.Instance.CurrentUser.attributeList)
        {
            newShop = Instantiate(swordShopTemplate, swordShopTemplate.transform.parent);
            newShopComponent = newShop.GetComponent<SwordShop>();
            newShopComponent.SetValue(attribute);
            newShop.SetActive(true);

            swordshopList.Add(newShopComponent);

        }
    }

    public void OnClickPickaxe()
    {
        SoundManager.instance.SFXPlay("Pickaxe", clip);
        GameManager.Instance.CurrentUser.jewel++;
        int randomJewel = Random.Range(1, 101);
        if (randomJewel < 6)
        {
            GameManager.Instance.CurrentUser.attributejewel++;
        }
        pickaxeAnimator.Play("Click");

        JewelText newText = null;
        if (GameManager.Instance.Pool.childCount > 0)
        {
            newText = GameManager.Instance.Pool.GetChild(0).GetComponent<JewelText>();
        }
        else
        {
            newText = Instantiate(jewelTextTemplate, GameManager.Instance.Canvas.transform).GetComponent<JewelText>();
        }

        newText.Show(Input.mousePosition);

        UpdateJewelPanel();
        UpdateattributeJewelPanel();

    }
    public void UpdateJewelPanel()
    {
        jewelText.text = string.Format("{0}", GameManager.Instance.CurrentUser.jewel);
    }
    public void UpdateattributeJewelPanel()
    {
        attributejewelText.text = string.Format("{0}", GameManager.Instance.CurrentUser.attributejewel);
    }


}
