using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detexionDePiso : MonoBehaviour {

    //Variables
    public bool tocaPiso;

    void OnCollisionStay2D(Collision2D collision)
    {
        tocaPiso = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        tocaPiso = false;
    }
}
