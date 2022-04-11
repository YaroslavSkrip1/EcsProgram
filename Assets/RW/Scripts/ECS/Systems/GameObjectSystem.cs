using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace RW.Scripts.ECS.Systems
{
    public class GameObjectSystem : ReactiveSystem<PlayerEntity>
    {
        public GameObjectSystem(IContext<PlayerEntity> context) : base(context)
        {
        }

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
        {
            return context.CreateCollector(PlayerMatcher.RWScriptsECSComponentDataGameObject);

        }

        protected override bool Filter(PlayerEntity entity)
        {
            return entity.hasRWScriptsECSComponentDataGameObject;
        }

        protected override void Execute(List<PlayerEntity> entities)
        {
            foreach (var entity in entities)
            {
                //entity.AddRWScriptsECSComponentDataMoveForvard();
                entity.AddRWScriptsECSComponentDataPosition(Vector3.zero);
            }
        }
    }
}