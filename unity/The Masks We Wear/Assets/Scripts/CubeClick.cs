using UnityEngine;

public class CubeClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        LifeSystem.Instance.LoseLife();
    }
}

