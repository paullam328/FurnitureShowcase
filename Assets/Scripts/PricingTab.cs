using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PricingTab : MonoBehaviour
{
    [SerializeField]
    private Text _originalPriceText;

    [SerializeField]
    private Text _discountedPriceText;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetOriginalPriceText(float price)
    {
        _originalPriceText.text = "CAD$" + price.ToString("0.00");
    }

    public void SetDiscountedPriceText(float price)
    {
        _discountedPriceText.text = "CAD$" + price.ToString("0.00");
    }
}
