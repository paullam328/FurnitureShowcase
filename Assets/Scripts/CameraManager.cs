using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CameraManager : MonoBehaviour
{

    public float _speed;

    public float _speedH = 2.0f;
    public float _speedV = 2.0f;

    private float _yaw = 0.0f;
    private float _pitch = 0.0f;

    private float _oldMouseX = 0.0f;
    private float _oldMouseY = 0.0f;

    private Rigidbody _rb;

    private float _rotateAllowanceDelay = 1f;
    private float _rotateAllowanceTimer;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            QuitGame();
        }

        if (!Cursor.visible)
        {
            MoveRotateCam();
        }

        //To avoid rigid body glitch from collision:
        _rb.velocity = Vector3.zero;
        
    }

    private void MoveRotateCam()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward, _speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position - transform.right, _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position - transform.forward, _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.right, _speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * _speed);
        }

        float _newMouseX = Input.GetAxis("Mouse X");
        float _newMouseY = Input.GetAxis("Mouse Y");

        _yaw = _speedH * _newMouseX;
        _pitch = -_speedV * _newMouseY;

        //calculated rotXFactor eulerAngles is returning random values:
        float curRotXFactor = transform.eulerAngles.x;
        if (curRotXFactor >= 270 && curRotXFactor <= 360)
        {
            curRotXFactor -= 360;
        }
        curRotXFactor *= -1;

        //Now it's returning the correct value (-90 and 90), time for some manual clamping:

        if (!((curRotXFactor > 75 && _newMouseY > 0)
           || (curRotXFactor < -75 && _newMouseY < 0)))
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x + _pitch,
                transform.eulerAngles.y + _yaw,
                transform.eulerAngles.z);
       }
    } 

    private void QuitGame()
    {
        // save any game data here
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
             Application.Quit();
#endif
    }
}