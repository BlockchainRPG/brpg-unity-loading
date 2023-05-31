using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingAnimation : MonoBehaviour
{
    public static LoadingAnimation instance;

    public string scenePath = "Assets/Repositories/brpg-unity-loading/Assets/ResourceData/LoadingAnimation.unity";

    void Awake()
    {
        DontDestroyOnLoad(this);
        instance = this;
    }

    public void StartLoading()
    {
        if (SceneManager.GetSceneByPath(scenePath).isLoaded == false)
            SceneManager
                .LoadSceneAsync(scenePath, LoadSceneMode.Additive)
                .completed += operation =>
            {
            };
    }

    public void StopLoading()
    {
        if (SceneManager.GetSceneByPath(scenePath).isLoaded)
            SceneManager.UnloadSceneAsync(scenePath);
    }
}
