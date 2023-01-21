using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMENTO : MonoBehaviour
{
    // dichiarazione di variabile di nome velocita e di tipo double ( float piu grande)
    // float velocita;
    // float spazio = 0;



    float velocita = 2f;
    float t;
    
    
    //float t1;


    //float xt = 0;
    //float yt =0;
    //float zt =0;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        // assegnamento di valore alla variabile 
        // velocita = (float)7 ;

        rend = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {



        //float tempo = Time.deltaTime;

        //spazio += velocita * tempo;
        // spazio = spazio + velocita * tempo;

        // sposto di 10 unit� il cubo in su
        //transform.position = new Vector3(spazio,spazio,spazio);

        // transform.Rotate(spazio,spazio,spazio);


        //cambia colore cubo
        //GameObject.Find("Cube").GetComponent<Renderer>().material.color = new Color(0, 204, 102);

        //cambia colore arcobaleno cubo
        //float tempo = Time.deltaTime;







        float tempo = Time.deltaTime;

        // t += velocita * tempo;

        float t = Mathf.PingPong(Time.time * velocita, 1);

        GameObject.Find("Cube").

        GetComponent<Renderer>().material.color = Color.Lerp(Color.yellow, Color.red, t);


        //GetComponent<Renderer>().material.color = new Color(0, 204, 102);


        //                                GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.blue, t);


       //xt +=1*velocita*tempo;
      // yt +=1*velocita * tempo;
       //zt +=1*velocita * tempo;

      // GetComponent<Renderer>().material.color = new Color(0, yt, zt);





    }
}
