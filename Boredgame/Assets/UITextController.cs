using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class UITextController : MonoBehaviour
{
    public UnityEvent startEvent;
    private Text textLabel;
    public UnityEvent down;
    
    public void UpdateText(FloatData data)
    {
        textLabel.text = data.value.ToString();
    }

    private void Update()
    {
        down.Invoke();
    }

    void Awake()
    {
        textLabel = GetComponent<Text>();
        startEvent.Invoke();
    }

}
