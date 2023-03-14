using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanel : MonoBehaviour
{
    [SerializeField]
    private Image pickaxeImage = null;
    [SerializeField]
    private Text pickaxeNameText = null;
    [SerializeField]
    private Text amountText = null;
    [SerializeField]
    private Text priceText = null;
    [SerializeField]
    private Button purchaseButton = null;
    [SerializeField]
    private Sprite[] pickaxeSprite = null;

    private Pickaxe pickaxe = null;
    public AudioClip clip;


    public void SetValue(Pickaxe pickaxe)
    {
        this.pickaxe = pickaxe;
        UpdateValues();
    }

    public void UpdateValues()
    {
        pickaxeImage.sprite = pickaxeSprite[pickaxe.pickaxeNumber];
        amountText.text = string.Format("{0}", pickaxe.amount);
        priceText.text = string.Format("{0}", pickaxe.price);
        pickaxeNameText.text = pickaxe.pickaxeName;
    }

    public void OnClickPurchase()
    {
        SoundManager.instance.SFXPlay("Purchase", clip);
        if (GameManager.Instance.CurrentUser.jewel < pickaxe.price)
        {
            return;
        }

        GameManager.Instance.CurrentUser.jewel -= pickaxe.price;
        pickaxe.amount++;
        pickaxe.price += (long)(pickaxe.price * 1.25f);
        UpdateValues();
        GameManager.Instance.UI.UpdateJewelPanel();
    }
}

