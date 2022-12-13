using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_system : MonoBehaviour
{
    public Text ScoreText;
    public int Punkty = 0;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PickUp")
        {
            Punkty += 150;
            ScoreText.GetComponent<Text>().text = "Punkty:" + Punkty;
            Destroy(other.gameObject);
        }
    }
}
