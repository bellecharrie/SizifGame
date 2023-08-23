using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDetectorScr : MonoBehaviour
{
    public bool almostThere = false;
    public bool almostThere2 = false;
    public bool almostThere3 = false;
    public bool rotated = false;
    public static int rotateCount;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Almost"))
        {
            Debug.Log("da");
            almostThere = true;

        }
        if(collision.CompareTag("Almost2") && almostThere)
        {
           
           almostThere2 = true;
        }
        if(collision.CompareTag("Almost3") && almostThere && almostThere2)
        {
            Debug.Log("dadd");
           
           almostThere3 = true;
        }

        if(collision.CompareTag("Rotate") && almostThere && almostThere2 && almostThere3)
        {
           rotateCount += 1;
           Debug.Log(rotateCount);
           almostThere = false;
           almostThere2 = false;
           almostThere3 = false;
        }
    }

    


}
