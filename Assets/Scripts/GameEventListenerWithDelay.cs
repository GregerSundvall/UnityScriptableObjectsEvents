// using System.Collections;
// using UnityEngine;
// using UnityEngine.Events;
//
//
// public class GameEventListenerWithDelay : GameEventListener
// {
//     [SerializeField] private float _delay = 0.2f;
//     [SerializeField] private UnityEvent _delayedUnityEvent;
//     
//     public override void RaiseEvent()
//     {
//         _unityEvent.Invoke();
//         StartCoroutine(RunDelayedEvent());
//     }
//
//     private IEnumerator RunDelayedEvent()
//     {
//         yield return new WaitForSeconds(_delay);
//         _delayedUnityEvent.Invoke();
//     }
// }
