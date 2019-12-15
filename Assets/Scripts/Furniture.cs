using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    [SerializeField]
    private int _id;
    public Sprite _pic;
    public string _name;
    //Information:
    public string _description;
    public int _rating; //from 0 to 5;

    //Pricing:
    public float _originalPrice = 0.00f;
    public float _discountPrice = 0.00f;

    //Contact:
    public string _contactName;
    public string _contactemail;
    public string _contactphone;
    public string _contactaddress;

    // Start is called before the first frame update
    void Start()
    {
        _pic = Resources.Load<Sprite>(_id.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetId()
    {
        return _id;
    }
}
