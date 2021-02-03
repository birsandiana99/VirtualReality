using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class GenerateBricks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject loadBrick = Resources.Load("Brick") as GameObject;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject initBrick = Instantiate(loadBrick) as GameObject;
                initBrick.transform.position = new Vector3(transform.position.x + i*2.01f,transform.position.y +j*1.05f, transform.position.z*1.05f);
            }
        }
    }

}
