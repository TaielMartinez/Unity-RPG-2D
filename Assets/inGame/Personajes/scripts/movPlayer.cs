using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlayer : MonoBehaviour {

    //Variables del golpe
    public Sprite normal;
    public Sprite golpe;
    public float timerGolpe;
    public bool golpeando;
    public bool puedeGolpear;

    //Variables del player
    public int playerNum;
    float velocidad;
    float salto;
  
    //Referencias
    public GameObject pies;
    Rigidbody2D rbPlayer;
    movPlyerConfig configuracionPlayer;

    //transform.Translate(Input.GetAxis("Horizontal") * velocidad / 3000, 0 , 0); PARA RECONOCER AXIS DEL JOYSTICK

    void Start () {

        rbPlayer = GetComponent<Rigidbody2D>();
        configuracionPlayer = GameObject.Find("mainVariables").GetComponent<movPlyerConfig>();

        velocidad = configuracionPlayer.velocidad;
        salto = configuracionPlayer.salto;
        rbPlayer.mass = configuracionPlayer.masa;
        rbPlayer.gravityScale = configuracionPlayer.gravedad;
        rbPlayer.drag = configuracionPlayer.drag;
    }
    
	void Update () {

        if (Input.GetButtonDown("jump" + playerNum) && pies.GetComponent<detexionDePiso>().tocaPiso)
            {
            rbPlayer.AddForce(Vector2.up * salto);
            }
            if (Input.GetButton("left" + playerNum))
            {
                rbPlayer.AddForce(Vector2.left * velocidad);
                GetComponent<Transform>().localEulerAngles = new Vector3(0, 0, 0);
            }
            if (Input.GetButton("right" + playerNum))
            {
                rbPlayer.AddForce(Vector2.right * velocidad);
                GetComponent<Transform>().localEulerAngles = new Vector3(0, 180, 0);
            }
        if (Input.GetButtonDown("skill1_" + playerNum))
        {
            GetComponent<habilidades>().dashear();
        }
        if (Input.GetButtonDown("skill2_" + playerNum))
        {
            GetComponent<habilidades>().lanzar();
        }
        if (Input.GetButtonDown("fire" + playerNum) && golpeando == false)
            {
                puedeGolpear = true;
                golpeando = true;
                GetComponent<SpriteRenderer>().sprite = golpe;
            }
            if (golpeando == true && timerGolpe < 0.1)
            {
                timerGolpe += Time.deltaTime;
            }
            else
            {
                puedeGolpear = false;
                golpeando = false;
                GetComponent<SpriteRenderer>().sprite = normal;
                timerGolpe = 0;
            }
    }
}