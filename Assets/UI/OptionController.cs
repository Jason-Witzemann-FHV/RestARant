using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    [SerializeField] private GameObject foodObject;
    [SerializeField] [TextArea] private string foodDescription;
    [SerializeField] private GameObject informationDescriptionObject;
    [SerializeField] private GameObject informationToggleObject;

    private Toggle toggleComponent;
    private Color activeColor;
    private Color inactiveColor;

    void Start()
    {
        toggleComponent = GetComponent<Toggle>();
        activeColor = toggleComponent.colors.selectedColor;
        inactiveColor = toggleComponent.colors.normalColor;
    }

    public void OnToggle(bool isActive)
    {
        if (isActive)
        {
            SetColorToActive();
            // ShowMenuItemAndResetScale();
            SetInformationDescription();
            ShowInformationToggle();
        }
        else
        {
            SetColorToInactive();
            // HideMenuItem();
            HideInformationToggle();
        }
    }

    private void SetColorToActive()
    {
        ColorBlock colors = toggleComponent.colors;
        colors.normalColor = activeColor;
        colors.selectedColor = activeColor;
        toggleComponent.colors = colors;
    }

    private void ShowMenuItemAndResetScale()
    {
        foodObject.GetComponentInParent<Transform>().transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        foodObject.SetActive(true);
    }

    private void SetInformationDescription()
    {
        informationDescriptionObject.GetComponent<TextMeshProUGUI>().text = foodDescription;
    }

    private void ShowInformationToggle()
    {
        informationToggleObject.SetActive(true);
    }

    private void SetColorToInactive()
    {
        ColorBlock colors = toggleComponent.colors;
        colors.normalColor = inactiveColor;
        colors.selectedColor = inactiveColor;
        toggleComponent.colors = colors;
    }


    private void HideMenuItem()
    {
        foodObject.SetActive(false);
    }

    private void HideInformationToggle()
    {
        informationToggleObject.GetComponent<Toggle>().isOn = false;
        informationToggleObject.SetActive(false);
    }
}
