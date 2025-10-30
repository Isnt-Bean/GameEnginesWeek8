using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed = 5f; // Movement speed

    void Update()
    {
        // Get input values
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        //float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Movement direction
        Vector3 direction = new Vector3(horizontal, 0f, 0f);

        // Apply movement
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
