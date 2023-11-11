using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ForLoops : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro;
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
                for (int i = 0; i < scores.Length; i++)
                {
                    average += scores[i];
                }
                TextMeshPro.text = $"Rata-ratanya adalah {average / scores.Length}";*/
        string nama = "";
        for (int i = 0; i < Name.Length; i++)
        {
            nama += Name[i] + " ";
        }
        TextMeshPro.text = nama;

    }

}
