using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAirResistance : MonoBehaviour
{
    public void ChangeBallDrag()
    {
        if (GameObject.Find("AirResistanceToggle").GetComponent<Toggle>().isOn)
        {
            //change background to sky
            //Sprite newSprite ;
            //GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = newSprite;

            float mass = GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().mass;
            GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag = 2.5f / (mass);

            //cap drag at 1
            if (GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag >= 1)
            {
                GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag = 1;
            }

            GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().drag = 0.5f;
        }
        else
        {
            GameObject.Find("GreenCircle").GetComponent<Rigidbody2D>().drag = 0;
            GameObject.Find("BlueCircle").GetComponent<Rigidbody2D>().drag = 0;
        }
    }
}
