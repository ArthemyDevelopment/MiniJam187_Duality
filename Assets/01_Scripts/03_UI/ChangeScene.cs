using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]private string SceneName;
    
    public void changeScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
