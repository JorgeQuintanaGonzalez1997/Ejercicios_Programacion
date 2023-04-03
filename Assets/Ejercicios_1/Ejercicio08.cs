using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Analytics;

namespace Ejercicios_1
{
    //Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    public class Ejercicio08 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameObject cube01;
            cube01 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube02;
            cube02 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube03;
            cube03 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube02.transform.localScale = new Vector3(cube01.transform.localScale.x * 2f, cube01.transform.localScale.y * 2f, cube01.transform.localScale.z * 2f);
            cube03.transform.localScale = new Vector3(cube02.transform.localScale.x * 2f, cube02.transform.localScale.y * 2f, cube02.transform.localScale.z * 2f);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}