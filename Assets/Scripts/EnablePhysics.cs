 using UnityEngine;

public class EnablePhysics : MonoBehaviour
{
    public void ApplyPhysics()
    {
        gameObject.AddComponent<Rigidbody>();
    }
}
