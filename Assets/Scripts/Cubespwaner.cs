using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubespwaner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] cube;
    public int cubeCount=0;
    public Vector3 center;

    public GameObject[] something;
    private void Awake()
    {

       // StartCoroutine(cubeSpwan());
    }
    void Start()
    {
        spwan();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spwan()
    {
        Vector3 pos =center+ new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        for(int i =0;i<10;i++)
        {
            something[i]=Instantiate(cube[Random.Range(0, 2)], pos, Quaternion.identity);
            

        }
    }

    /*IEnumerator cubeSpwan()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            spwan();
        }
    }*/
}
