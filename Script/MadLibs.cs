using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MadLibs : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private bool statement = true;
    private string verb = "Drink";
    private string noun = "Coffee";
    private string adj = "Manner ";
    private int number = 20;
    private string plurannoun = "People";
    private float percent = 50.4F;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"This is statement is {statement}, i did not {verb} the {noun}. i am not guily. i am a {adj} person. The act was performed by {number} wandering {plurannoun}. i am {percent}% sure of this.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
