using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public double x = 0;
    public double y = 0;
    public GameObject[] tilePrefabs;
    private List<GameObject> activeTiles = new List<GameObject>();
    private float spawnPos = 0;
    private float tileLength = 20;

    [SerializeField] private Transform player;
    private int startTiles = 3;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < startTiles; i++)
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x - 28 > spawnPos - (startTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }

    }

   private void SpawnTile(int tileIndex)
   {
    GameObject nextTile = Instantiate(tilePrefabs[tileIndex], new Vector3((float)x, (float)y,0), Quaternion.Euler(0f,0f,20f));
      activeTiles.Add(nextTile);
        x += 18.79385;
        y += 6.840402;
      spawnPos += tileLength;
   }
    private void DeleteTile()
   {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
