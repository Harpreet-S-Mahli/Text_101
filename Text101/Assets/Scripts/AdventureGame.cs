using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Now can be manipulated in the inspector
    [SerializeField] Text textComponent;
    

    //the first state to start the game on
    [SerializeField] State startingState;

    //used to keep track of our current state
    State state;

    // Start is called before the first frame update
    void Start()
    {
        //intialize the first state of the game to start
        state = startingState;

        //call method to grab text from the state object into the textComponent
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();

        if (Input.GetKey("escape") || Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    //when player presses a number, the state will update to the number selected
    private void ManageState()
    {
        State[] nextStates = state.GetNextStates();

        for(int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }
      /*  
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        */
        //call method to grab text from the state object into the textComponent
        textComponent.text = state.GetStateStory(); 
    }
}
