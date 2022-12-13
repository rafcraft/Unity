using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        print(Vector3.Distance(temp.transform.position, this.transform.position));

    }
}
