using Input;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;

namespace Player
{
    public class MouseInteraction : MonoBehaviour
    {
        [SerializeField] private InteractionReader _reader;
        private Vector2 _screenPosition;
        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
            _reader.OnMoveEvent.AddListener(GetScreenPosition);
            _reader.OnClickEvent.AddListener(Click);
        }

        private void Click()
        {
            Ray ray = _camera.ScreenPointToRay(_screenPosition);
            if (Physics.Raycast(ray, out var hit, Mathf.Infinity,LayerMask.GetMask("Ground")))
            {
                Debug.Log(hit.point);
                Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere), hit.point, Quaternion.identity);
            }
        }

        private void GetScreenPosition(Vector2 screenPosition)
        {
            _screenPosition = screenPosition;
        }
        
        
    }
}
