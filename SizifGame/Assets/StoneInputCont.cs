using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StoneInputCont : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public float offset;
    Camera MainCamera;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = Camera.allCameras[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log(eventData.position);
        
        
    }
    public void OnDrag(PointerEventData eventData)
    {
       Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f,0f, rotateZ + offset);
        //Quaternion rotating = Quaternion.LookRotation(difference);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(rotateZ, Vector3.forward), speed);
       
    }
    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
