using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyTenary : MonoBehaviour
{
    public int currentPlayer;
    private string message;
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMessage()
    {
        if (currentPlayer > 0)
        {
            string player = (currentPlayer % 2 == 1) ? "Player one" : "Player Two";
            textMeshPro.text = $"Ready {player}";
        }
        else
        {
            textMeshPro.text = "Gk jelas lu";
        }
    }
}
