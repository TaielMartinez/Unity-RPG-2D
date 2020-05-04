using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiendaDome : MonoBehaviour {

    //Variables
    bool joystick;

    //Referencias
    perfilesJugador estadisticas;
   // itemsConfigStadisticas datos;

    private void Start()
    {
        estadisticas = GameObject.Find("mainVariables").GetComponent<perfilesJugador>();
        //datos = GameObject.Find("mainVariables").GetComponent<itemsConfigStadisticas>();
    }

    // A esta función se la llama con un botón. Se le asigna el gameObject del item que se desea añadir,
    // y al presionar el botón se copia al array correspondiente. Según que int reciba, es el tipo de item, y se decide en qué array deben copiarse sus datos.
    public void añadirItem(itemsConfigStadisticas scr)
    {
        if (scr.tipoDeItem == 0)
        {
            estadisticas.arma = scr.armaStats;
        }
        else if (scr.tipoDeItem == 1)
        {
            estadisticas.armadura = scr.armaduraStats;
        }
        else if(scr.tipoDeItem == 2)
        {
            estadisticas.arrojable = scr.arrojableStats;
        }
    }

    /*
    public void espada2()
    {
        estadisticas.arma2 = datos.espada;
    }

    
    public void acha()
    {
        estadisticas.arma = datos.hacha;
    }
    public void acha2()
    {
      estadisticas.arma2 = datos.hacha;
    }


    public void shuriken()
    {
        estadisticas.arrojable = datos.shuriken;
    }
    public void shuriken2()
    {
        estadisticas.arrojable2 = datos.shuriken;
    }


    public void arco()
    {
        estadisticas.arrojable = datos.arco;
    }
    public void arco2()
    {
        estadisticas.arrojable2 = datos.arco;
    }


    public void pesada()
    {
        estadisticas.armadura = datos.pesada;
    }
    public void pesada2()
    {
        estadisticas.armadura2 = datos.pesada;
    }


    public void ligera()
    {
        estadisticas.armadura = datos.ligera;
    }
    public void ligera2()
    {
        estadisticas.armadura2 = datos.ligera;
    }
    */
}