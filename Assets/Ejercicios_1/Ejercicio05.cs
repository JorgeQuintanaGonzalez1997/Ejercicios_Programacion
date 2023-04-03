using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;
namespace Ejercicios_1
{
    public class Ejercicio05 : MonoBehaviour
    {
        //Crear un script que genere 30 GameObjects al inicio
        // Start is called before the first frame update
        void Start()
        {
            for (int i=0;i<30;i++)
            {
                GameObject objeto = new GameObject();

            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
