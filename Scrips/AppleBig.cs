using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleBig : MonoBehaviour
{
    public Button Apple;
    void OnCollisionEnter2D(Collision2D Maca)
    {
        if (Maca.gameObject.tag == "Player")
        {
            Apple.gameObject.SetActive(true);
        }
    }

}
