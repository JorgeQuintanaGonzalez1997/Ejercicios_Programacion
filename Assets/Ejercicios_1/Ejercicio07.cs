using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace Ejercicios_1
{
    //Crear un script que genere tres esferas al inicio separadas 100 metros
    public class Ejercicio07 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject esfera01;
            esfera01 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera02;
            esfera02 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera03;
            esfera03 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera01.transform.position = new Vector3(1f, 1f, 1f);
            esfera02.transform.position = new Vector3(esfera01.transform.position.x*100f, 1f, 1f);
            esfera03.transform.position = new Vector3(esfera01.transform.position.x * 100f, 1f, esfera02.transform.position.z * 100);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

