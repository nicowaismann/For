using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiafor : MonoBehaviour
{
    public GameObject prefab;
    public int cantidadDeClones;
    public int grados;
    

    public void CloneObject()
    {

        GameObject clon;

        for (int i = 0; i < cantidadDeClones; i++)
        {
            clon = Instantiate(prefab);
            clon.transform.Rotate(0, grados*i, 0);
            clon.transform.Translate(i, i, 0);
            Destroy(clon,3);
        }
        
    }
}
