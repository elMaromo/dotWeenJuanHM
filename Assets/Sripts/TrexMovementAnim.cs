using DG.Tweening;
using UnityEngine;

namespace Sripts
{
    public class TrexMovementAnim : MonoBehaviour
    {
        private void Start()
        {
            SpinSecuence();
            MoveSecuence();
        }

        public void SpinSecuence()
        {
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(transform.DORotate(new Vector3(0,30,0), 1));
            mySequence.Append(transform.DORotate(new Vector3(0,-30,0), 1));
            mySequence.Append(transform.DORotate(new Vector3(0,30,0), 1));
            mySequence.Append(transform.DORotate(new Vector3(0,0,0), 1));

            mySequence.SetLoops(-1);
        }
    
        public void MoveSecuence()
        {
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(transform.DOMoveZ(5, 3).SetEase(Ease.Linear));
            mySequence.Append(transform.DOMoveZ(0, 1).SetEase(Ease.Linear));


            mySequence.SetLoops(-1);
        }
    
    }
}
