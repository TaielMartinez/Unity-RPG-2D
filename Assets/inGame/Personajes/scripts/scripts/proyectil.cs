using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<vida>() != null)
        {
            collision.gameObject.GetComponent<vida>().vidaActual -= 5;
        }
        Destroy(gameObject);
    }
}
