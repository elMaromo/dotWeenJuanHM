using DG.Tweening;
using UnityEngine;

namespace Sripts
{
    public class CameraShake : MonoBehaviour
    {
        public float intensity;
        public float duration;
        public float pauseTime;

        private void Start()
        {
            Shake();
        }

        public void Shake()
        {
            Sequence mySequence = DOTween.Sequence();

            mySequence.Append(transform.DOShakePosition(duration, intensity));
            mySequence.AppendInterval(pauseTime);
            mySequence.SetLoops(-1);
        }
    }
}