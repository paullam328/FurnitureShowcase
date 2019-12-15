using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationTab : MonoBehaviour
{
    [SerializeField]
    private Image _image;
    [SerializeField]
    private GameObject _stars;
    [SerializeField]
    private Text _descriptionText;

    public int _rating;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_rating >= 0)
        {
            for (int i = 0; i < _rating; i++)
            {
                _stars.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }

    public void SetImage(Sprite image)
    {
        _image.sprite = image;
    }

    public void SetDescriptionText(string description)
    {
        _descriptionText.text = description;
    }

    void OnEnable()
    {
    }

    void OnDisable()
    {
        _rating = -1;
        for (int i = 0; i < _stars.transform.childCount; i++)
        {
            _stars.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
