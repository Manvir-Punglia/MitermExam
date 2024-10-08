using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : Observer
{
   private int score = 0; 
   public override void Notify(Subject subject)
   {
      score += 100;
      Debug.Log("The score is ");
      Debug.Log(score);
      
   }
}
