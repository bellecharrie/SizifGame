using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StoneInputCont : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public float offset;
    Camera MainCamera;

    public float speed = 5f;

    public float timeLeft = 1.5f;
    public bool DetectorOfDegrees;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = Camera.allCameras[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectorOfDegrees)
        {
            
           timeLeft -= Time.deltaTime;
           if(timeLeft < 0f)
           {
            DeadDetector();
            timeLeft = 1.5f;
           }

        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log(eventData.position);
        
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        DetectorOfDegrees = true;
       Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f,0f, rotateZ + offset);
        //Quaternion rotating = Quaternion.LookRotation(difference);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(rotateZ, Vector3.forward), speed);
       
    }
    public void OnEndDrag(PointerEventData eventData)
    {

    }

    public void DeadDetector()
    {
        
      if (RotateDetectorScr.rotateCount < 1 )
      {
        Debug.Log("dead");
            SceneManager.LoadScene(0);
        
      }
      RotateDetectorScr.rotateCount = 0;
      
    }



}
