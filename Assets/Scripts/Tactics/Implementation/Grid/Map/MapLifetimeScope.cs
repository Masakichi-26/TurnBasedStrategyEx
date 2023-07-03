using VContainer;
using VContainer.Unity;
using UnityEngine;

public class MapLifetimeScope : LifetimeScope
{
    [SerializeField] private MouseWorld mouseWorld;
    [SerializeField] private InputManager inputManager;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponent(mouseWorld);
        builder.RegisterComponent(inputManager);

        builder.Register<PlayerInputActions>(Lifetime.Scoped).AsSelf();
    }
}
