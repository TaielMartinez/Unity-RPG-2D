using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perfilesJugador : MonoBehaviour {

    //           ESTADISTICAS DE LOS JUGADORES

    //      PLAYER 1:
    public int[] arma = new int[] {  0,  0,  0, 0 };
    public int[] armadura = new int[] { 0, 0, 0, 0 };
    public int[] arrojable = new int[] { 0, 0, 0, 0, 0, 0 };

    //      PLAYER 2:
    public int[] arma2 = new int[] { 0, 0, 0, 0 };
    public int[] armadura2 = new int[] { 0, 0, 0, 0 };
    public int[] arrojable2 = new int[] { 0, 0, 0, 0, 0, 0 };



    void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
}
