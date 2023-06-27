using UnityEngine;
using UnityEngine.UI;

public class CardButton : MonoBehaviour
{
    public DestinationCard destinationCard;
    public Image originSprite;
    public Image destinationSprite;

    public Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        destinationCard.ToggleImage();
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(OnButtonClick);
    }
}

