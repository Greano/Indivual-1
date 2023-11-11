using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class numberGuesser : MonoBehaviour
{
    public int guess;
    public int randomNumber;
    private TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
        TextMeshPro.text = "Pick number between 1 - 10";
        randomNumber = Random.Range(1,10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckGuess()
    {
        if (guess < 11 && guess > 0)
        {
            if (guess == randomNumber)
            {
                TextMeshPro.text = "Kamu benar";
            }
            else if (guess > randomNumber)
            {
                TextMeshPro.text = "Terlalu tinggi";
            }
            else
            {
                TextMeshPro.text = "Terlalu Rendah";
            }
        }
        else
        {
            TextMeshPro.text = "1 - 10 ANjay";
        }

    }
}
