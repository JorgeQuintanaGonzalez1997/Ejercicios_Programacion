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
        //No s� como proceder. He intentado a�adir un componente com�n (Un collider) para, a traves de �l acceder a los nombres de todos.

       
        void Update()
        {
            
        }
    }

}

