using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactTab : MonoBehaviour
{
    [SerializeField]
    private Text _nameText;

    [SerializeField]
    private Text _emailText;

    [SerializeField]
    private Text _phoneText;

    [SerializeField]
    private Text _addressText;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetNameText(string name)
    {
        _nameText.text = name;
    }

    public void SetEmailText(string email)
    {
        _emailText.text = email;
    }

    public void SetPhoneText(string phone)
    {
        _phoneText.text = phone;
    }

    public void SetAddrText(string addr)
    {
        _addressText.text = addr;
    }
}
