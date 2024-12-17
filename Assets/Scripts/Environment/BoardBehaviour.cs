using Environment.Defenses;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.Serialization;

namespace Environment
{
    public class BoardBehaviour : MonoBehaviour
    {
        [SerializeField] private Vector2Int sizeGrid;
        [SerializeField] private int sizeSquare;
        [SerializeField] private NavMeshSurface surface;
        public GameObject[,] Board { get; private set; }
        
        public void Awake()
        {
            Board = new GameObject[sizeGrid.y,sizeGrid.x];
            for (int i = 0; i < sizeGrid.y; ++i)
            {
                for (int j = 0; j < sizeGrid.x; ++j)
                {
                    Board[i,j] = null;
                }
            }
        }

        public bool PlaceDefense(DefenseBehaviour defense, Vector2Int position)
        {
            if (IsFree(position))
            {
                GameObject defenseObject = Instantiate(defense.gameObject,
                    new Vector3(position.x * sizeSquare , 0.5f, position.y * sizeSquare),Quaternion.identity);
                Board[position.y,position.x] = defenseObject;
                return true;
            }
            return false;
        }
        
        public bool IsFree(Vector2Int position)
        {
            if (IsPositionOutsideBoundaries(position))
            {
                return false;
            }
            return !Board[position.y, position.x];
        }

        private bool IsPositionOutsideBoundaries(Vector2Int position)
        {
            return position.x < 0 || position.x >= sizeGrid.x || position.y < 0 || position.y >= sizeGrid.y;
        }

        public Vector2Int WorldSpaceToGrid(Vector3 position)
        {
            int x = Mathf.FloorToInt(position.x);
            int y = Mathf.FloorToInt(position.z);
            int resultX = x / sizeSquare;
            int resultY = y / sizeSquare;
            return new Vector2Int(resultX,resultY);
        }

        private bool IsEndPositionFree()
        {
            // Check if we can access the last pos
            return false;
        }
    }
}
