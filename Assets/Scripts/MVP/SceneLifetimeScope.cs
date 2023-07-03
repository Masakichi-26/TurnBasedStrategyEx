using VContainer;
using VContainer.Unity;

public abstract class SceneLifetimeScope<TPresenter, TModel, TView> : LifetimeScope
    where TPresenter : IPresenter
    where TModel : IModel
    where TView : IView
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<TModel>(Lifetime.Scoped);
        builder.RegisterComponentInHierarchy<TView>();
        builder.RegisterEntryPoint<TPresenter>(Lifetime.Scoped);
    }
}
