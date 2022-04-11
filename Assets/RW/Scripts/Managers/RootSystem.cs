using RW.Scripts.ECS.Systems;

namespace RW.Scripts.Managers
{
    public class RootSystem : Feature
    {
        public RootSystem(Contexts contexts)
        {
            Add(new GameObjectSystem(contexts.player));
            
            Add(new PlayerPositionSystem(contexts.player));
        }
        
    }
}