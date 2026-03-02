using UnityEngine;

public class SyncBones : MonoBehaviour
{
    // Այս դաշտում պետք է գցես Body_011-ը
    public SkinnedMeshRenderer targetBody; 

    void Start()
    {
        SkinnedMeshRenderer myRenderer = GetComponent<SkinnedMeshRenderer>();
        
        if (targetBody != null && myRenderer != null)
        {
            myRenderer.bones = targetBody.bones;
            myRenderer.rootBone = targetBody.rootBone;
        }
    }
}