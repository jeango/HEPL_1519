using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnDestroy()
    {
        GameManager.GameOver();
    }
}
