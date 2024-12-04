using Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class MouseInteraction : MonoBehaviour
    {
        [SerializeField] private InteractionReader _reader;
        private Vector2 _screenPosition; 

        private void Awake()
        {
            _reader.OnMoveEvent.AddListener(GetScreenPosition);
            _reader.OnClickEvent.AddListener(Click);
        }

        private void Click()
        {
            
        }

        private void GetScreenPosition(Vector2 screenPosition)
        {
            _screenPosition = screenPosition;
        }
        
        
    }
}
