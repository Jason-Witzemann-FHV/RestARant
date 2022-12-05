using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    [SerializeField] private GameObject menuItem;
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
            SpawnMenuItem();
        }
        else
        {
            SetColorToInactive();
            DespawnMenuItem();
        }
    }

    private void SetColorToActive()
    {
        ColorBlock colors = toggleComponent.colors;
        colors.normalColor = activeColor;
        toggleComponent.colors = colors;
    }

    private void SpawnMenuItem()
    {
        menuItem.GetComponentInParent<Transform>().transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        menuItem.SetActive(true);
    }

    private void SetColorToInactive()
    {
        ColorBlock colors = toggleComponent.colors;
        colors.normalColor = inactiveColor;
        toggleComponent.colors = colors;
    }


    private void DespawnMenuItem()
    {
        menuItem.SetActive(false);
    }
}
