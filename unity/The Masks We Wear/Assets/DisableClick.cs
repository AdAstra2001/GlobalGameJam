using NUnit.Framework;
using UnityEngine;

public class DisableClick : MonoBehaviour
{
    public static DisableClick Instance;
    public bool maskChosen = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }


}
