using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ejercicios_1
{
    //Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    public class Ejercicio10 : MonoBehaviour
    {
        
        void Start()
        {
            BoxCollider box = gameObject.AddComponent<BoxCollider>();
            
            BoxCollider[] boxes = GameObject.FindObjectsOfType<BoxCollider>();
        }
        //No sé como proceder. He intentado añadir un componente común (Un collider) para, a traves de él acceder a los nombres de todos.

       
        void Update()
        {
            
        }
    }

}

