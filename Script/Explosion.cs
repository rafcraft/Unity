using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject prefab;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject temp = GameObject.Instantiate(prefab);
        temp.transform.position = this.transform.position;
        GameObject.Destroy(this);
    }
}
