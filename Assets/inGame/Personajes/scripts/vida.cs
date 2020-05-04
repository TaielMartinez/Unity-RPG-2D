using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour {

    //Valor de vida actual
    public float vidaActual;

    //Elementos del cadaver
    public GameObject death;
    Transform deathPos;

	void Start ()
    {
        deathPos = death.transform;
        vidaActual = 100;
	}
	
	void Update ()
    {
        if(vidaActual <= 0)
        {
            Destroy(gameObject);
            deathPos.Translate(new Vector3(transform.position.x - deathPos.position.x, transform.position.y - deathPos.position.y));
        }
	}
}
