using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objscore : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("shape"))
        {
            Score.instance.Updatescore(-1);
            other.gameObject.SetActive(false);
            spawner.instance.activeObj.SetActive(false);
           spawner.instance.Spawn2();


        }

    }
}
