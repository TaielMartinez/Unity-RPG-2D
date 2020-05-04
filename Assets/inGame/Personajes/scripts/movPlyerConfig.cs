using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class movPlyerConfig : MonoBehaviour
{

    public float velocidad;
    public float salto;
    public float masa;
    public float gravedad;
    public float drag;

    public void Reset()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}