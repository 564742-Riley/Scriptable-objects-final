using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerScript : MonoBehaviour
{
    public PlayerSO playerSO;
    public TextMeshProUGUI Data;

    void Start()
    {

    }

    void Update()
    {
        Data.text = "Name: " + playerSO.Name + "\nScore: " + playerSO.Score + "\nHealth: " + playerSO.Health;

        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            playerSO.Score--;
        }

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            playerSO.Score++;
        }
    }

    
   
        

    
}
