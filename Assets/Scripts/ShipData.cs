using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(fileName = "Data", menuName = "Ship", order = 1)]
public class ShipData : ScriptableObject
{
    //Establecer las diferentes estadísticas que pueden tener las naves; velocidad, escudo y velocidad de disparo.
    public string spaceshipName;
    [Range(1f, 10f)] //Esto determina el rango mínimo y máximo al que puede llegar la estadística. Uno por cada estadística diferente.
    public float speed;
    [Range(1f, 10f)]
    public float shield;
    [Range(1f, 10f)]
    public float rof;

}
