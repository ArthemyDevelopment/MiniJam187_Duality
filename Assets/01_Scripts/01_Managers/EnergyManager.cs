using ArthemyDev.ScriptsTools;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManager : SingletonManager<EnergyManager>
{
    [SerializeField]private float minimunEnergyRequired;
    [SerializeField] private float TotalEnergy;
    [SerializeField] private Image EnergyBar;

    protected override void Awake()
    {
        base.Awake();
        TotalEnergy = ((float)(minimunEnergyRequired * 1.5) * 2);
        CurrentEnergy = TotalEnergy;
    }


    private float _currentEnergy;
    
    private float CurrentEnergy
    {
        get
        {
            return _currentEnergy;
        }
        set
        {
            CheckEnergyRemaining(value);
            _currentEnergy = value;
        }
    }

    private void CheckEnergyRemaining(float value)
    {
        EnergyBar.fillAmount = ScriptsTools.MapValues(value, 0, TotalEnergy, 0, 1);
        //if(value==0) OutOfTimeEnding; 
    }

    public bool IsSolutionOnTime()
    {
        if (CurrentEnergy >= (minimunEnergyRequired * 1.5)) return true;
        else return false;
    }

    public void SpendEnergy(float cost)
    {
        CurrentEnergy -= cost;
    }
    
    
}
