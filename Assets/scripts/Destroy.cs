using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
    
{
    // Start is called before the first frame update
   
    void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.CompareTag("shape"))
        {
            Score.instance.Updatescore(+1);
            spawner.instance.activeObj.SetActive(false);
            spawner.instance.Spawn2();
            other.gameObject.SetActive(false);

        }
        
    }
}
