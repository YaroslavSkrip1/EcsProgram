using Entitas;
using RW.Scripts.ECS.ComponentData;
using Zenject;

namespace RW.Scripts.ECS.Systems
{
    public class MovementSystem : IExecuteSystem
    {
        [Inject] private PlayerContext _context;
        public void Execute()
        {
            foreach (var entity in _context.GetEntities())
                entity.rWScriptsECSComponentDataGameObject.value.GetComponent<MoveForvardComponent>().speed
                    = entity.rWScriptsECSComponentDataMoveForvard.speed;
            
        }
    }
}