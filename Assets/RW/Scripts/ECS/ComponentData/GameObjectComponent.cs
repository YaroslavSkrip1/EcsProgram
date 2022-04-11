using Entitas;
using UnityEngine;

namespace RW.Scripts.ECS.ComponentData
{
    [Player]
    public class GameObjectComponent : IComponent
    {
        public GameObject value;
    }
}