using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ChangeColor : MonoBehaviour,IInputClickHandler
{
    private Material ThisRendere;

    // Start is called before the first frame update
    void Start()
    {
        ThisRendere = GetComponent<MeshRenderer>().material;
    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        //ThisRendere.color = Color.magenta;
        ChangeMyColor();
    }

    public void ChangeMyColor()
    {
      ThisRendere.color = Color.magenta;
    }
}
