using DG.Tweening;
using UnityEngine;

namespace Sripts
{
    public class TrexHeadAnim : MonoBehaviour
    {
        private void Start()
        {
            UpAndDown();
            RotateHead();
        }

        public void UpAndDown()
        {
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(transform.DOMoveY(5.5f, 0.5f));
            mySequence.Append(transform.DOMoveY(4.5f, 0.5f));
            mySequence.Append(transform.DOMoveY(5.5f, 0.5f));
            mySequence.Append(transform.DOMoveY(4.5f, 0.5f));
            mySequence.Append(transform.DOMoveY(5.5f, 0.5f));
            mySequence.Append(transform.DOMoveY(7f, 0.5f));
            mySequence.Append(transform.DOMoveY(7, 0.5f));
            mySequence.Append(transform.DOMoveY(5.5f, 0.5f));
        
            mySequence.SetLoops(-1);
        }
    
        public Sequence RotateHead()
        {
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(transform.DOLocalRotate(new Vector3(10,-40,0), 1));
            mySequence.Append(transform.DOLocalRotate(new Vector3(20,40,0), 1));
            mySequence.Append(transform.DOLocalRotate(new Vector3(-10, -20,20), 0.2f));
            mySequence.Append(transform.DOLocalRotate(new Vector3(-20,-20,-20), 0.2f));
            mySequence.Append(transform.DOLocalRotate(new Vector3(-30,-20,20), 0.2f));
            mySequence.Append(transform.DOLocalRotate(new Vector3(-40,-20,-20), 0.2f));
            mySequence.Append(transform.DOLocalRotate(new Vector3(-50,-20,0), 0.2f));
            mySequence.Append(transform.DOLocalRotate(new Vector3(0,0,0), 1));

            mySequence.SetLoops(-1);
        
            return mySequence;
        }
    }
}
