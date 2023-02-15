using DG.Tweening;
using UnityEngine;

namespace Sripts
{
    public class GroundAnim : MonoBehaviour
    {
        public float speed;
        private void Start()
        {
            MoveGound();
        }

        public void MoveGound()
        {
            Sequence mySequence = DOTween.Sequence();
        
            mySequence.Append(transform.DOMoveZ(-speed, 1f).SetEase(Ease.Linear));

            mySequence.SetLoops(-1);
        }
    }
}
