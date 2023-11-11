using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ForEachLoops : MonoBehaviour
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
        foreach (int score in scores)
        {
            average = average + score;
            increment = increment + 1;
        }         
        TextMeshPro.text = $"Rata-ratanya adalah {average / scores.Length} ngeloop sebanyak {increment}";*/
        string nama = "";
        foreach (string nam in Name)
        {
            nama += nam + " ";
        }
        TextMeshPro.text = nama;

    }

}
