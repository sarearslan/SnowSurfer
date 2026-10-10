using UnityEngine;

[CreateAssetMenu(fileName = "Powerup", menuName = "PowerupSO")]
public class PoweupSO : ScriptableObject
{
    [SerializeField] string poweupType;
    [SerializeField] float valueChange;
    [SerializeField] float time;

    public string GetPowerupType()
    {
        return poweupType;
    }

    public float GetValueChange()
    {
        return valueChange;
    }

    public float GetTime()
    {
        return time;
    }
}
