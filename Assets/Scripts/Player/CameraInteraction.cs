using System;
using Input;
using UnityEngine;

namespace Player
{
    public class CameraInteraction : MonoBehaviour
    {
        [SerializeField] private CameraInteractionReader readerInput;
        [SerializeField] private float speedMove;
        [SerializeField] private float speedZoom;

        [SerializeField] private float maxZoom;
        [SerializeField] private float minZoom;
        
        private Vector2 _velocity;
        private float _currentZoom;
        private float _previousZoom;

        private void Awake()
        {
            _currentZoom = maxZoom;
            _previousZoom = maxZoom;
        }

        private void OnEnable()
        {
            readerInput.onMoveCamera.AddListener(RetrieveDirection);
            readerInput.onZoomCamera.AddListener(GetZoom);
        }

        private void RetrieveDirection(Vector2 direction)
        {
            _velocity = direction;
        }

        private void GetZoom(float axis)
        {
            axis = Mathf.Clamp(axis, -1, 1);
            _previousZoom = _currentZoom;
            _currentZoom = Mathf.Clamp(_currentZoom + (axis * speedZoom), minZoom, maxZoom);
        }

        private void Update()
        {
            Move();
            Zoom();
        }

        private void Zoom()
        {
            Vector3 previousPosition = new Vector3(transform.position.x, _previousZoom, transform.position.z);
            Vector3 targetPosition = new Vector3(transform.position.x, _currentZoom, transform.position.z);
            transform.position = Vector3.Lerp(previousPosition, targetPosition, Time.deltaTime * speedZoom);
        }


        private void Move()
        {
            if (_velocity != Vector2.zero)
            {
                transform.position += new Vector3(_velocity.x, 0, _velocity.y) * (Time.deltaTime * speedMove);
            }
        }
    }
}
