using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class DoWhile : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro;
/*    public int[] scores;*/
    public string[] Name;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShownMessage()
    {
        /*        int average = 0;
                int increment = 0;
                do
                {
                    average += scores[increment];
                    increment++;
                } while (increment < scores.Length);*/
        /*        while (increment < scores.Length)*/
        /*        {
                    average += scores[increment];
                    increment++;
                }*/
        /*        TextMeshPro.text = $"Rata-ratanya adalah {average / scores.Length} ngeloop sebanyak {increment}";*/
        string nama = " ";
        int increment = 0;
        do
        {
            nama += Name[increment] + " ";
            increment++;
        } while (increment < Name.Length);
/*        while (increment < Name.Length)*/
/*        {
            nama += Name[increment];
            nama += " ";
            increment++;
        }*/
        TextMeshPro.text = nama;

    }

}
