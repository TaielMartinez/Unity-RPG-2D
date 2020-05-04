using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detexionEspada : MonoBehaviour
{
    //Referencias del player
    public GameObject movPlayer;
    movPlayer scriptPlayer;

    //Variables
    public bool tocaEspada;


    void Start()
    {
        scriptPlayer = movPlayer.GetComponent<movPlayer>();
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        tocaEspada = true;
        if (collision.gameObject.GetComponent<vida>() != null && scriptPlayer.puedeGolpear)
        {
            collision.gameObject.GetComponent<vida>().vidaActual -= 5;
            scriptPlayer.puedeGolpear = false;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        tocaEspada = false;
    }
    
}