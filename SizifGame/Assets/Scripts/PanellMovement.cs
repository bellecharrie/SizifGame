using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanellMovement : MonoBehaviour
{
    [SerializeField] private Transform panel;
    //public Transform target;
    private Vector3 pos;

    


    private void Update()
    {

        transform.position = Vector3.Lerp(transform.position, new Vector3(0, -208f, 0), Time.deltaTime);
    }
}
