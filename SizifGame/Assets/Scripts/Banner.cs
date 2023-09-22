using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banner : MonoBehaviour
{
    [SerializeField] private Transform baner;
    public Transform target;
    private Vector3 pos;

    
    private void Update()
    {


        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
    }
}
