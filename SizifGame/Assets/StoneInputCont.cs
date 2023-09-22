using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StoneInputCont : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject spinToPush;
    public GameObject pLost;
    public float offset;
    Camera MainCamera;

    public float speed = 5f;

    public float timeLeft = 1.5f;
    public bool DetectorOfDegrees;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = Camera.allCameras[0];
        Time.timeScale = 0f;
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
            timeLeft = 3f;
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
        Time.timeScale = 1f;
        spinToPush.SetActive(false);
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
            Time.timeScale = 0f;
            pLost.SetActive(true);
        
      }
      RotateDetectorScr.rotateCount = 0;
      
    }



}
