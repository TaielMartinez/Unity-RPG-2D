using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsConfigStadisticas : MonoBehaviour
{
    //SINTAXIS DE ESTADISTICAS
    //      ARMAS
    // [0] Daño
    // [1] Peso
    // [2] Velodcidad de ataque
    // [3] Tiempo de casteo

    //      ARMADURAS
    // [0] Defensa mele
    // [1] Defensa rango
    // [2] Defensa magia
    // [3] Peso

    //      ARROJABLES
    // [0] Daño
    // [1] Rango
    // [2] Cantidad
    // [3] Casteo animacion
    // [4] Casteo mantener
    // [5] Cargas

   public int tipoDeItem;
    //TIPOS DE ITEM
    // 0 = ARMA
    // 1 = ARMADURA
    // 2 = ARROJABLE

    public int[] armaStats = new int[] {
    /* DAÑO */      0, 
    /* PESO */      0,
    /* SPEED */     0,
    /* CASTEO */    0
    };



    public int[] armaduraStats = new int[] {
    /* MELE */      0, 
    /* RANGO */     0,
    /* MAGIA */     0,
    /* PESO */      0
    };
    public int[] arrojableStats = new int[] {
    /* DAÑO */      0, 
    /* RANGO */     0,
    /* CANTIDAD */  0,
    /* CAST A */    0,
    /* CAST M */    0,
    /* CARGAS */    0
    };

}