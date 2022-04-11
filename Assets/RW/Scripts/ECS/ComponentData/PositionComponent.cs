using Entitas;
using UnityEngine;

namespace RW.Scripts.ECS.ComponentData
{
    [Player]
    public class PositionComponent : IComponent
    {
        public Vector3 value;
    }
}