using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Brick");
    }
    

    // Update is called once per frame
    void Update()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Brick");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject go in gos)
                Destroy(go);
        }
    }
}
