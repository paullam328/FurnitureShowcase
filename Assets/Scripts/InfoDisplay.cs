using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ETab
{
    Information = 0,
    Pricing,
    Contact
}

public class InfoDisplay : MonoBehaviour
{

    private ETab _activeTab = ETab.Information;

    [SerializeField]
    private GameObject _informationBody;
    [SerializeField]
    private GameObject _pricingBody;
    [SerializeField]
    private GameObject _contactBody;

    [SerializeField]
    private Text _nameField;
    private string _name;

    private ItemDataHandler _idh;
    private Furniture _furniture;

    //load all sprites:


    

    private void Start()
    {
        _idh = gameObject.AddComponent<ItemDataHandler>();
    }

    public void SetActiveTab(int tab)
    {
        _activeTab = (ETab) tab;
    }

    public void RetrieveData(Furniture f)
    {
        //1. Instead of using the new keyword, use AddComponent<>() instead.  Or else it ignores monobehav:
        //2. Call coroutine in the same class to keep the reference within:
        _furniture = f;

        if (!_idh)
        {
            _idh = gameObject.AddComponent<ItemDataHandler>();
        }
        _idh.StartPostIDGetData(f);
    }


    void Update()
    {
        _name = _furniture._name;
        _nameField.text = _name;

        switch (_activeTab)
        {
            case ETab.Information:
                DisplayInformationBody();
                break;

            case ETab.Pricing:
                DisplayPricingBody();
                break;

            case ETab.Contact:
                DisplayContactBody();
                break;
        }
    }

    public void DisableDisplay()
    {
        Cursor.visible = false;
        gameObject.SetActive(false);
    }

    public void DisplayInformationBody()
    {
        _informationBody.SetActive(true);
        _informationBody.GetComponent<InformationTab>().SetImage(_furniture._pic);
        _informationBody.GetComponent<InformationTab>()._rating = _furniture._rating;
        _informationBody.GetComponent<InformationTab>().SetDescriptionText(_furniture._description);
        _pricingBody.SetActive(false);
        _contactBody.SetActive(false);
        
    }

    public void DisplayPricingBody()
    {
        _informationBody.SetActive(false);
        _pricingBody.SetActive(true);
        _pricingBody.GetComponent<PricingTab>().SetOriginalPriceText(_furniture._originalPrice);
        _pricingBody.GetComponent<PricingTab>().SetDiscountedPriceText(_furniture._discountPrice);
        _contactBody.SetActive(false);


    }

    public void DisplayContactBody()
    {
        _informationBody.SetActive(false);
        _pricingBody.SetActive(false);
        _contactBody.SetActive(true);
        _contactBody.GetComponent<ContactTab>().SetNameText(_furniture._contactName);
        _contactBody.GetComponent<ContactTab>().SetEmailText(_furniture._contactemail);
        _contactBody.GetComponent<ContactTab>().SetPhoneText(_furniture._contactphone);
        _contactBody.GetComponent<ContactTab>().SetAddrText(_furniture._contactaddress);

    }
}
