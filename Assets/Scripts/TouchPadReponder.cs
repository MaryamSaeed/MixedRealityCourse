using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class TouchPadReponder : MonoBehaviour,IControllerTouchpadHandler
{ 
    public void OnInputPositionChanged(InputPositionEventData eventData)
    {
        //how to react to the controller position change
        var ControllerPos = eventData.Position;//same as axies from -1 to 1 in X and y
    }

    public void OnTouchpadReleased(InputEventData eventData)
    {
        //touchpad relesed
    }

    public void OnTouchpadTouched(InputEventData eventData)
    {
     //tochpad touched   

    }

}
