using DG.Tweening;
using UnityEngine;

namespace Sripts
{
    public class JawAnim : MonoBehaviour
    {
        private void Start()
        {
            UpAndDown();
        }

        public void UpAndDown()
        {
            Sequence mySequence = DOTween.Sequence();

            mySequence.Append(transform.DOLocalRotate(new Vector3(-10,0,0), 2));
            mySequence.Append(transform.DOLocalRotate(new Vector3(30,0,0), 1));
            mySequence.Append(transform.DOLocalRotate(new Vector3(0,0,0), 1));

            mySequence.SetLoops(-1);
        }
    }
}
