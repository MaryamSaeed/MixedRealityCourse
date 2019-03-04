using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class HoldResponder : MonoBehaviour,IHoldHandler,ISpeechHandler
{
    public Mesh AlterMesh;
    public string MagicWord;
    private MeshFilter ThisMeshFilter;
    // Start is called before the first frame update
    void Start()
    {
        ThisMeshFilter = GetComponent<MeshFilter>();
    }
    public void OnHoldCanceled(HoldEventData eventData)
    {
    }

    public void OnHoldCompleted(HoldEventData eventData)
    {
        //ThisMeshFilter.mesh = AlterMesh;
        AlterMeshFilter();
    }

    public void OnHoldStarted(HoldEventData eventData)
    {
    }

    public void AlterMeshFilter()
    {
      ThisMeshFilter.mesh = AlterMesh;
    }

    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        if (GazeManager.Instance.HitObject == gameObject && eventData.RecognizedText == MagicWord)
            AlterMeshFilter();
    }
}
