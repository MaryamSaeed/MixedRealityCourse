using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class XboxInputs : MonoBehaviour, IXboxControllerHandler
{
    public void OnXboxInputUpdate(XboxControllerEventData eventData)
    {
        var X = eventData.GamePadName;
    }
}

   
