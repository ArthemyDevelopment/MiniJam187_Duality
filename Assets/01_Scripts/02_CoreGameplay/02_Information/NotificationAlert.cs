using ArthemyDev.ScriptsTools;
using UnityEngine;

[DefaultExecutionOrder(-2)]
public class NotificationAlert : SingletonManager<NotificationAlert>
{
    [SerializeField] private Animator newInfoAnim;
    [SerializeField] private Animator newClueDescAnim;
    
    public void TriggerNotificacionNewInformation()
    {
        newInfoAnim.SetTrigger("newInfo");
    }

    public void TriggerNotificationNewClueDescription()
    {
        newClueDescAnim.SetTrigger("newClueDesc");
    }
}
