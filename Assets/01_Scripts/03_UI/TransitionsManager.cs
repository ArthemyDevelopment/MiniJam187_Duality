using ArthemyDev.ScriptsTools;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class TransitionsManager : SingletonManager<TransitionsManager>
{
    [SerializeField] private Animator anim;
    private Transform tpCamerTarget;
    private string sceneTarget;

    public void TransitionLocation(Transform locationTarget)
    {
        tpCamerTarget = locationTarget;
        anim.SetTrigger("short");
    }

    public void TpCamera()
    {
        Camera.main.transform.position = tpCamerTarget.position;
    }

    public void ChangeScene(string scene)
    {
        
        sceneTarget = scene;
        
        anim.SetTrigger("long");
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneTarget);
    }
}
