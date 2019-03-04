using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class FocusDetction : MonoBehaviour,IFocusable
{
    private MeshRenderer ThisRendrer;
    // Start is called before the first frame update
    void Start()
    {
        ThisRendrer = GetComponent<MeshRenderer>();
    }
    public void OnFocusEnter()
    {
        ThisRendrer.material.color = Color.red;
    }

    public void OnFocusExit()
    {
        ThisRendrer.material.color = Color.green;
    }
}
