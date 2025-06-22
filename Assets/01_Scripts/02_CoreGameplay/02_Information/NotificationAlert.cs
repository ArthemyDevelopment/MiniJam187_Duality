using ArthemyDev.ScriptsTools;
using UnityEngine;

[DefaultExecutionOrder(-2)]
public class NotificationAlert : SingletonManager<NotificationAlert>
{
    [SerializeField] private Animator newInfoAnim;
    
    public void TriggerNotificacionNewInformation()
    {
        newInfoAnim.SetTrigger("newInfo");
    }
}
