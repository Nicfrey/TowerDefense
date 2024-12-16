using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Input
{
    [CreateAssetMenu(menuName = "Input/Camera Interaction Reader", fileName = "CameraInteractionSO", order = 1)]
    public class CameraInteractionReader : ScriptableObject, Controls.ICameraInteractionActions
    {
        private Controls _controls;

        public UnityEvent<Vector2> onMoveCamera;
        public UnityEvent<float> onZoomCamera;

        private void OnEnable()
        {
            if (_controls == null)
            {
                _controls = new Controls();
                _controls.CameraInteraction.SetCallbacks(this);
            }
            _controls.CameraInteraction.Enable();
            
        }

        private void OnDisable()
        {
            _controls.CameraInteraction.Disable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            onMoveCamera?.Invoke(context.ReadValue<Vector2>());
        }

        public void OnZoom(InputAction.CallbackContext context)
        {
            onZoomCamera?.Invoke(context.ReadValue<float>());
        }
    }
}
