using ArthemyDev.ScriptsTools;
using UnityEngine;

public class NotificationAlert : SingletonManager<NotificationAlert>
{
    [SerializeField] private Animator newInfoAnim;
    
    public void TriggerNotificacionNewInformation()
    {
        newInfoAnim.SetTrigger("newInfo");
    }
}
