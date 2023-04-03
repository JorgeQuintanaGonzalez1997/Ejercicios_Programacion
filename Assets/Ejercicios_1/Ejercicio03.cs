using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace Ejercicios_1
{
    //Crear un script que genere un cubo al inicio y duplique su escala
    public class Ejercicio03 : MonoBehaviour
    {
        
        // Start is called before the first frame update
        void Start()
        {

            GameObject cubo;
            cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.transform.localScale = Vector3.one * 2;


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}