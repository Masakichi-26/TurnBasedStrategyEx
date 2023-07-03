using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IView
{
    UniTask AfterBind();
}

public abstract class View : MonoBehaviour, IView
{
    public virtual async UniTask AfterBind()
    {
        await UniTask.CompletedTask;
    }
}
