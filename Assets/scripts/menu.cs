using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    // Start is called before the first frame update
    public void Baslat()
    {
        SceneManager.LoadScene(1);
        /*Oyunun bulundu�u sahnenin numaras� 
         parantezin i�ine yaz�lacak.*/
    }
    public void C�k�s()
    {
        Application.Quit();
    }
}
