using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace Ejercicios_1
{
    //Crear un script que genere dos esferas al inicio separadas 100 metros
    public class Ejercicio06 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject esfera01;
            esfera01 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera02;
            esfera02 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera01.transform.position = new Vector3(100f, 0f, 0f);
            esfera02.transform.position = new Vector3(0f, 0f, 0f);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
