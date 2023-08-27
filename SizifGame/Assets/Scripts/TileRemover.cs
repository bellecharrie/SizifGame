using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRemover : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public int tileIndex = 0;
    //private List<GameObject> activeTiles = new List<GameObject>();
    // private float spawnPos = 0;
    private float tileLength = 60;

    [SerializeField] private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        MoveTail();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveTail()
    {
        tilePrefabs[tileIndex].transform.Translate(Vector3.right * 1);
       // activeTiles.Add(nextTile);
    }
}
