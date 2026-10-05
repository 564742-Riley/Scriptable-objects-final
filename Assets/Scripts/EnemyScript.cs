using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyScript : MonoBehaviour
{
    public PlayerSO playerSO;

    void Update()
    {
        if (Keyboard.current.minusKey.wasPressedThisFrame)
        {
            playerSO.Health--;
        }

        if (Keyboard.current.equalsKey.wasPressedThisFrame)
        {
            playerSO.Health++;
        }
    }
}
