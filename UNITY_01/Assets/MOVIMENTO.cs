using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMENTO : MonoBehaviour
{
    Camera m_MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        //abilito camera principale
       
    }

    // Update is called once per frame
    void Update()
    {
        // sposto di 10 unità il cubo in su
        transform.position = new Vector3(0,10,0);

        // sposto di 10 unità il cubo in giu
        transform.position = new Vector3(0, -10, 0);

        //cambia colore cubo
        GameObject.Find("Cube").GetComponent<Renderer>().material.color = new Color(0, 204, 102);

    }
}
