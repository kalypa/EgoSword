using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordShop : MonoBehaviour
{
    [SerializeField]
    private Image attributeImage = null;
    [SerializeField]
    public Text swordNameText = null;
    [SerializeField]
    public Text levelText = null;
    [SerializeField]
    private Text priceText = null;
    [SerializeField]
    private Button levelupButton = null;
    [SerializeField]
    private Sprite[] attributeSprite = null;
    [SerializeField]
    private SwordRevolution swordRevolution;

    private Attribute attribute = null;
    public AudioClip clip;
    private void Start()
    {
        swordRevolution.AllLevel();
    }
    public void SetValue(Attribute attribute)
    {
        this.attribute = attribute;
        UpdateValues();
    }

    public void UpdateValues()
    {
        attributeImage.sprite = attributeSprite[attribute.SwordNumber];
        levelText.text = string.Format("{0}", attribute.Level);
        priceText.text = string.Format("{0}", attribute.price);
        swordNameText.text = attribute.SwordName;
    }

    public void OnClickLevelup()
    {
        SoundManager.instance.SFXPlay("SwordShop", clip);
        if (GameManager.Instance.CurrentUser.attributejewel < attribute.price)
        {
            return;
        }

        GameManager.Instance.CurrentUser.attributejewel -= attribute.price;
        attribute.Level++;
        attribute.price += (long)(attribute.price * 0.2f);
        UpdateValues();
        swordRevolution.AllLevel();
        GameManager.Instance.UI.UpdateattributeJewelPanel();
    }

}
