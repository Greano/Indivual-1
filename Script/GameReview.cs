using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UIElements;

public enum Game
{
    Amazing,
    Great,
    Mediocre,
    Trash,
    NotRated
}
public class GameReview : MonoBehaviour
{
    public Game game;
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
        switch(game)
        {
            case Game.Amazing:
                textMeshPro.text = "starfield";
                break;
            case Game.Great:
                textMeshPro.text = "Alienisolation";
                break;
            case Game.Trash:
                textMeshPro.text = "BaldursGateThree";
                break;
            case Game.Mediocre:
                textMeshPro.text = "HalfLifThree";
                break;
            case Game.NotRated:
                textMeshPro.text = "Gollum";
                break;
            default:
                textMeshPro.text = "Agak lain";
                break;
        }
    }
}
