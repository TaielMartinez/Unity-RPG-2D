using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habilidades : MonoBehaviour {

    //Variables del DASH
    public bool dashing;
    public float timerDashing;
    public float dashCooldown;
    public float speedDash;
    public Animator animDash;


    //Variables de LANZAR
    public bool lanzando;
    public float timerLanzar;
    public float lanzarCooldown;
    public float potDisparo;
    public GameObject proyectil;
    public Transform launchPos;


    public void dashear ()
    {
        if (dashing == false)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * -speedDash, ForceMode2D.Impulse);
            dashing = true;
            animDash.SetBool("glowing", false);
        }
    }
    public void lanzar()
    {
        if (lanzando == false)
        {
            var bullet = Instantiate(proyectil, launchPos.position, launchPos.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * -potDisparo;
            Destroy(bullet, 2.0f);
            lanzando = true;
        }
    }
    void Update()
    {
        if(dashing == true)
        {
            timerDashing += Time.deltaTime;
        }
        if(timerDashing>= dashCooldown)
        {
            dashing = false;
            timerDashing = 0;
        }
        if(timerDashing >= 0.2)
        {
            animDash.SetBool("glowing", true);
        }
        if (lanzando == true)
        {
            timerLanzar += Time.deltaTime;
        }
        if (timerLanzar >= lanzarCooldown)
        {
            lanzando = false;
            timerLanzar = 0;
        }
    }
}
