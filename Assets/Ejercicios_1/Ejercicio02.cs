using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    //Crear un script que genere un GameObject al inicio y trasladarlo a la posicion (111.1, -5, 4.5)

    public class Ejercicio02 : MonoBehaviour
    {
        public GameObject player;
        // Start is called before the first frame update
        void Start()
        {
            GameObject objeto = new GameObject();
            objeto.transform.position = new Vector3(111.1f, -5f, 4.5f);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}