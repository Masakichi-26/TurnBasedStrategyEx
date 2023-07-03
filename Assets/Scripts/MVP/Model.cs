using Cysharp.Threading.Tasks;

public interface IModel
{
    UniTask AfterBind();
}

public class Model : IModel
{
    public async UniTask AfterBind()
    {
        await UniTask.CompletedTask;
    }
}
