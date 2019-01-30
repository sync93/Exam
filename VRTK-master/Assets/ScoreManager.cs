using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score1;
    public static int score2;
    public static int score3;
    public static int score4;
    public static int score5;

    public string textfill;
    public static int spawnAmount;
    public bool spider = false;
    Text text;
    public bool set1 ;
    public bool set2 ;
    public bool set3;
    public bool set4 ;
    public bool set5 ;

    

    void Awake ()
    {
        text = GetComponent <Text> ();
       
    }


    void Update ()
    {
        
        if (set1 == true)
        {
            text.text = textfill+score1;
        }
        if (set2 == true)
        {
            text.text = textfill + score2;
        }
        if (set3 == true)
        {
            text.text = textfill + score3;
        }
        if (set4 == true)
        {
            text.text = textfill + score4;
        }
        if (set5 == true)
        {
            text.text = textfill + score5;
        }

        if (spider == true) {
            text.text = textfill + spawnAmount;
        }
    }
}
