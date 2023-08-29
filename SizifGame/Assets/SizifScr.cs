using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizifScr : MonoBehaviour
{
    public Animator sizifAnimator;
    public Transform stonePosition;
    public Vector3 offsetStone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = stonePosition.position + offsetStone;
        
        if (RotateDetectorScr.rotateCount > 0)
        {
            sizifAnimator.SetBool("isPushing", true);
        }else
        {
            sizifAnimator.SetBool("isPushing", false);
        }
    }
}
