using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ejercicios_1
{
    public class Ejercicio09 : MonoBehaviour
    {
        float p = 1f;
        //Crear un script que genere 12 esferas cada una el doble de grande que la anterior
        // Start is called before the first frame update
        void Start()
        {



            for (int i = 0; i < 12; i++)
            {
                GameObject esfera;
                esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.localScale = new Vector3(p, p, p);
                p = p * 2;
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


