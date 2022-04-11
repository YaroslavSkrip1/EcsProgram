using RW.Scripts.ECS.Systems;
using Zenject;

public class UntitledInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<MovementSystem>().AsSingle();
        Container.BindInterfacesAndSelfTo<GameObjectSystem>().AsSingle();
        Container.BindInterfacesAndSelfTo<PlayerPositionSystem>().AsSingle();
        
    }
}