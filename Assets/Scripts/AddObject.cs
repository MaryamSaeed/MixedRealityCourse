using HoloToolkit.Unity;
using UnityEngine;

public class AddObject : MonoBehaviour
{
    public PrimitiveType Objecttype;
    private GameObject Generated;
    public void Generate()
    {
        Generated = GameObject.CreatePrimitive(Objecttype);
        Generated.transform.localScale = 0.2f * Vector3.one;
        var Tap2Place = Generated.AddComponent<TapToPlaceScene>();
        Tap2Place.DistanceFromHead = 3;
        Tap2Place.Placing = true;
    }
}
