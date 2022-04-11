using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace RW.Scripts.ECS.Systems
{
    public class PlayerPositionSystem : ReactiveSystem<PlayerEntity>
    {
        public PlayerPositionSystem(IContext<PlayerEntity> context) : base(context)
        {
        }

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
        {
            return context.CreateCollector(PlayerMatcher.RWScriptsECSComponentDataPosition);
        }

        protected override bool Filter(PlayerEntity entity)
        {
            return entity.hasRWScriptsECSComponentDataPosition;
        }

        protected override void Execute(List<PlayerEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.rWScriptsECSComponentDataGameObject.value.GetComponent<MeshRenderer>().transform.position
                    = entity.rWScriptsECSComponentDataPosition.value;
            }
        }
    }
}