using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    Image _healthColor;
    [SerializeField]
    Slider _healthBar;

    void Awake()
    {
        _healthBar = GetComponentInChildren<Slider>();
    }

    void Update()
    {
        ChangeColor();
    }

    public void ChangeColor()
    {
        if (_healthBar.value >= 70f)
        {
            _healthColor.GetComponent<Image>().color = new Color32(155, 255, 0 ,255);
        }
        else if (_healthBar.value >= 40f)
        {
            _healthColor.GetComponent<Image>().color = new Color32(255, 205, 0, 255);
        }
        else if (_healthBar.value >= 0f)
        {
            _healthColor.GetComponent<Image>().color = new Color32(255, 15, 0 , 255);
        }
    }
}
