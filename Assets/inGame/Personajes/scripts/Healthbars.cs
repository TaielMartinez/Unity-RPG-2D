using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbars : MonoBehaviour {

    public RectTransform barraDeVida;
    public float health;
    public vida player;

	void Update () {
       health = player.vidaActual;
        barraDeVida.localScale = new Vector2(health / 100, barraDeVida.localScale.y);
    }
}