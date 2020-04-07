using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Now can be manipulated in the inspector
    [SerializeField] Text textComponent;
    string wordsInTextComponent;

    // Start is called before the first frame update
    void Start()
    {
        wordsInTextComponent = "Wow";
        textComponent.text = wordsInTextComponent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
