using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace Ejercicios_1
{
    //Crear un script que genere una esfera al inicio con un Rigidbody añadido

    public class Ejercicio04 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject esfera;
            esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera.AddComponent<Rigidbody>();
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
