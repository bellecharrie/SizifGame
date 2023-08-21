using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneMovingScr : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField] 
    private float t = 0.0f;
    [SerializeField]
    private bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space))
      {
        rb.velocity = new Vector3(10,0,0);
        moving = true;
        Debug.Log("move");
      }

      if(moving)
      {
        t = t + Time.deltaTime;
        if (t > 5.0f)
        Debug.Log(gameObject.transform.position.x + " : " + t);
        t = 0.0f;
      }
    }


    void FIxedUpdate()
    {
    
      

    }

}
