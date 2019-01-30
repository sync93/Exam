using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public string textfill;
    public static int spawnAmount;
    public bool spider = false;
    Text text;
    public bool set1 = false;
    public bool set2 = false;
    public bool set3 = false;
    public bool set4 = false;
    public bool set5 = false;

    public float timer = 150f;

    void Awake ()
    {
        text = GetComponent <Text> ();
        score = 0;
    }


    void Update ()
    {
        timer -= Time.deltaTime;
        text.text = textfill + score;

        if (spider == true) {
            text.text = textfill + spawnAmount;
        }
    }
}
