using UnityEngine;
using System.Collections;
using System;

public class CorrectAnswerList :  IComparable<CorrectAnswerList> {

    public int answerId;

    public CorrectAnswerList(int answer)
    {
        answerId = answer;
    }
    
    //This method is required by the IComparable
    //interface. 
    public int CompareTo(CorrectAnswerList other)
    {
        if(other == null)
        {
            return 1;
        }
        
        //Return the difference in power.
        return answerId - other.answerId;
    }
}
