using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class JewelText : MonoBehaviour
{
    private Text jewelText = null;

    public void Show(Vector2 mousePosition)
    {
        jewelText = GetComponent<Text>();
        jewelText.text = string.Format("+{0}", 1);

        gameObject.SetActive(true);
        transform.SetParent(GameManager.Instance.Canvas.transform);
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);

        RectTransform rectTransform = GetComponent<RectTransform>();
        float targetPositionY = rectTransform.anchoredPosition.y + 100f;

        jewelText.DOFade(0f, 0.5f).OnComplete(() => Despawn());
        rectTransform.DOAnchorPosY(targetPositionY, 0.5f);
    }

    private void Despawn()
    {
        jewelText.DOFade(1f, 0f);
        transform.SetParent(GameManager.Instance.Pool);
        gameObject.SetActive(false);
    }
}