using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public int totalScore;
    public static Score instance;
    [SerializeField] private TextMeshProUGUI _text;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    public void Updatescore(int value)
    {
        totalScore += value;
        Debug.Log(totalScore);
        _text.text = totalScore.ToString();
    }
}
