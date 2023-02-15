using DG.Tweening;
using UnityEngine;

namespace Sripts
{
    public class ExplorerAnim : MonoBehaviour
    {
        public float distance;
        public float timeJump;
        public float timeSliding;
        public float heightJump;

        private Vector3 initPos;
        private Vector3 posTarget;
        private void Start()
        {
            initPos = transform.position;
            posTarget = initPos;
            posTarget.z += distance;
            Jump();
        }

        public void Jump()
        {
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(transform.DOJump( posTarget, heightJump, 1, timeJump).SetEase(Ease.OutQuad));
            mySequence.Append(transform.DOMove(initPos, timeSliding).SetEase(Ease.Linear));

            mySequence.SetLoops(-1);
        }
    }
}
