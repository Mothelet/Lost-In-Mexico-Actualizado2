﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Señora_Pueblo_M3 : MonoBehaviour
{
    //Reconcocera al personaje en trigger
    public GameObject player;

    //Para la pieza a elegir
    public GameObject pieza;

    //Elegir el charro

    public GameObject Charro;
    // Start is called before the first frame update
    void Start()
    {
        //busca al jugador que se puso con el tag 
        player = GameObject.FindGameObjectWithTag("Player");
        //Desaparece la pieza
        pieza.SetActive(false);
        Charro.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Para l acolision de trigger
    private void OnTriggerEnter2D(Collider2D collider)
    {

        //Si se choca con el tag se dira el texto ya aparecera la pieza
        if (collider.tag == "Player")
        {

            Debug.Log("Esta foto es de mi nieta porfavor ayúdame");
            Debug.Log("Se la llevo el charro negro");


            //Memorama_0.gameObject.GetComponent<Renderer>().enabled;
            //Se pondra la pieza visible

            pieza.SetActive(true);
            Charro.SetActive(true);


        }

    }
}
