using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;



public class LegAnim : MonoBehaviour
{
    public bool isLefT;
    
    private void Start()
    {
        if (isLefT)
        {
            
        }
        else
        {
            
        }
        UpAndDown();
    }

    public void UpAndDown()
    {
        Sequence mySequence = DOTween.Sequence();
        


        mySequence.SetLoops(-1);


        mySequence.SetLoops(-1);
    }
}
