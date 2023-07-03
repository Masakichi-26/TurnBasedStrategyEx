using VContainer.Unity;

public interface IPresenter
{
    void BindToModel();
    void BindToView();
}

public abstract class Presenter<TModel, TView> : IPresenter, IStartable
    where TModel : IModel, new()
    where TView  : IView
{
    public TModel Model { get; }
    public TView View { get; }

    public Presenter(TModel model, TView view)
    {
        Model = model;
        View  = view;
    }

    async void IStartable.Start()
    {
        BindToModel();
        BindToView();

        await Model.AfterBind();
        await View.AfterBind();
    }

    public abstract void BindToModel();
    public abstract void BindToView();
}
