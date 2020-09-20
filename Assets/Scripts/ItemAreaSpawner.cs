
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemAreaSpawner : MonoBehaviour
{
    public GameObject itemToSpread;
    public int numItemsToSpawn = 10;
    public Vector3 center;
    /*public float itemXSpread = 10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;*/
    public int blocks;
    // Start is called before the first frame update
    void Start()
    {
        blocks = 0;
        for (int i = 0; i < numItemsToSpawn; i++)
        {          
            SpreadItem();
            blocks++;

        }
        PlayerPrefs.SetInt("Blocks", blocks);
    }

    void SpreadItem()
    {
         Vector3 pos = new Vector3(Random.Range(-10, 10), 10, Random.Range(-10, 10));
        GameObject clone = Instantiate(itemToSpread, pos, Quaternion.identity );//itemToSpread.transform.rotation
    }
    private void Update()
    {
        Debug.Log("Blocks: "+blocks);
        
    }
}