using UnityEngine;
using UnityEngine.SceneManagement;

namespace Title
{
    public class TitleModel : Model
    {
        public void OpenMap1()
        {
            Debug.Log("Open Map 1");
            SceneManager.LoadSceneAsync("MapBase2D");
        }
    }
}
