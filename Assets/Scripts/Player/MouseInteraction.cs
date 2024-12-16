using Environment.Defenses;
using Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Player
{
    public class MouseInteraction : MonoBehaviour
    {
        [SerializeField] private InteractionReader reader;
        [SerializeField] private GameObject[] defensePrefabs;
        private int _indexDefenseSelection;
        private Vector2 _screenPosition;
        private Camera _camera;
        private GameObject _visualisation;

        private Vector2Int _gridPosition;
        public UnityEvent<Vector2Int, Vector2Int> onChangePosition;
        
        private void Awake()
        {
            _camera = Camera.main;
            reader.OnMoveEvent.AddListener(GetScreenPosition);
            reader.OnClickEvent.AddListener(Click);
            _visualisation = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
        }

        private void Click()
        {
            Ray ray = _camera.ScreenPointToRay(_screenPosition);
            if (Physics.Raycast(ray, out var hit, Mathf.Infinity,LayerMask.GetMask("Ground")))
            {
                DefenseBehaviour defense = defensePrefabs[_indexDefenseSelection].GetComponent<DefenseBehaviour>();
                if (GameManager.Instance.Board.PlaceDefense(defense, _gridPosition))
                {
                    Debug.Log("Defense Placed");
                }
                else
                {
                    Debug.LogError("You can't place defenses here" + _gridPosition);
                }
            }
        }

        private void GetScreenPosition(Vector2 screenPosition)
        {
            _screenPosition = screenPosition;
            Ray ray = _camera.ScreenPointToRay(_screenPosition);
            if (Physics.Raycast(ray, out var hit, Mathf.Infinity, LayerMask.GetMask("Ground")))
            {
                _gridPosition = GameManager.Instance.Board.WorldSpaceToGrid(hit.point);
                Debug.Log("Cell pos : " + _gridPosition);
                //_visualisation.transform.position = new Vector3(_gridPosition.x * GameManager.Instance.Board.GridWorld.cellSize.x, 1.5f, _gridPosition.y * GameManager.Instance.Board.GridWorld.cellSize.y);
                _visualisation.transform.position = hit.point;
            }
        }
        
        
    }
}
