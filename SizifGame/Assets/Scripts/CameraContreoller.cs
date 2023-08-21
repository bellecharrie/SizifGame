using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContreoller : MonoBehaviour
{
    [SerializeField] private Transform circle_Lehi;
    private Vector3 pos;

    //private void Awake()
    //{
    //    if (!player)
    //        player = FindObjectOfType<circle_Lehi>().transform;
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        pos = circle_Lehi.position;
        pos.z = -10f;

        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}
