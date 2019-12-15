using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
public class CursorController : MonoBehaviour
{
    private Image _img;
    [SerializeField]
    private GameObject _infoDisplay;

    public float _clickDelayTimer = 0;
    private float _clickDelay = 0.2f;

    [SerializeField]
    private Texture2D _cursorTexture;

    // Start is called before the first frame update
    void Start()
    {
        _img = GetComponent<Image>();
        Cursor.visible = false;
        _clickDelayTimer = _clickDelay + 1;
        Cursor.SetCursor(_cursorTexture, Vector2.zero, CursorMode.Auto);
        
    }

    void ClickDelayAfterInfoWindowDisappear()
    {
        if (Cursor.visible)
        {
            _clickDelayTimer = 0;
        }
        if (_clickDelayTimer < _clickDelay)
        {
            _clickDelayTimer += Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _img.enabled = !_infoDisplay.activeSelf;

        ClickDelayAfterInfoWindowDisappear();

        if (!_infoDisplay.activeSelf && _clickDelayTimer > _clickDelay)
        {
            Cursor.lockState = CursorLockMode.Locked;
            RaycastHit hit;
            int layerMask = 1 << 11;

            layerMask = ~layerMask;

            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(Camera.main.gameObject.transform.position,
                Camera.main.gameObject.transform.TransformDirection(Vector3.forward),
                out hit,
                Mathf.Infinity,
                layerMask))
            {
                Debug.DrawRay(Camera.main.gameObject.transform.position,
                    Camera.main.gameObject.transform.TransformDirection(Vector3.forward) * hit.distance,
                    Color.yellow);
                //Debug.Log("Did Hit: " + hit.collider.gameObject.name);

                if (Input.GetMouseButtonUp(0))
                {
                    _infoDisplay.SetActive(true);
                    if (hit.collider.transform.GetComponent<Furniture>())
                    {
                        _infoDisplay.GetComponent<InfoDisplay>().RetrieveData(hit.collider.transform.GetComponent<Furniture>());
                    }
                    else if (hit.collider.transform.GetComponentInParent<Furniture>())
                    {
                        _infoDisplay.GetComponent<InfoDisplay>().RetrieveData(hit.collider.transform.GetComponentInParent<Furniture>());
                    }
                    else
                    {
                        Debug.Log("Can't Find furniture: " +  hit.collider.transform.name);
                    }
                    Cursor.lockState = CursorLockMode.None;
                }

                _img.color = Color.yellow;
            }
            else
            {
                Debug.DrawRay(Camera.main.gameObject.transform.position,
                    Camera.main.gameObject.transform.TransformDirection(Vector3.forward) * 1000,
                    Color.white);
                //Debug.Log("Did not Hit");

                _img.color = Color.white;
            }
        }

        SetCursorState();
    }

    void SetCursorState()
    {
        Cursor.visible = _infoDisplay.activeSelf;
    }
}
