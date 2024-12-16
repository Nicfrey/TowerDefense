using UnityEngine;

namespace Environment.Defenses
{
    public enum OrientationDefense
    {
        Front,
        Left,
        Up,
        Back
    }
    public class DefenseBehaviour : MonoBehaviour
    {
        public OrientationDefense Orientation { get; set; }
        
        [SerializeField] private int size;
        public int Size => size;
        
        
    }
}
