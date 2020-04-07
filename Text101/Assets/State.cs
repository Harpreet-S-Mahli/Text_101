using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    //in TextArea, the first number is the minimum size of the TextField in the Inspector. Second number is the
    //number of lines that will stored in the box before it startes scrolling
    [TextArea(10,14)] [SerializeField] string storyText;

    //an array that contains all possible states that are next after the current one
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    } 

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
