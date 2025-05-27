using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // 遷移したいシーン名
    public string StageSelectScript;

    public void ChangeScene()
    {
        SceneManager.LoadScene(StageSelectScript);
    }
}
