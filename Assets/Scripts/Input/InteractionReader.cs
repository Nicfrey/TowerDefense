using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Input
{
    [CreateAssetMenu(menuName = "Input/Interaction Reader", fileName = "InteractionReaderSO",order = 0)]
    public class InteractionReader : ScriptableObject, Controls.IGameInteractionsActions
    {
        private Controls _controls;
        
        public UnityEvent<Vector2> OnMoveEvent;

        public UnityEvent OnClickEvent;

        private void OnEnable()
        {
            if (_controls == null)
            {
                _controls = new Controls();
                _controls.GameInteractions.SetCallbacks(this);
            }
            _controls.GameInteractions.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            OnMoveEvent?.Invoke(context.ReadValue<Vector2>());

        }

        public void OnClick(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                OnClickEvent?.Invoke();
            }
        }
    }
}
