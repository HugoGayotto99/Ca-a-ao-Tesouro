using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    public Transform player; 

    public float rotationSpeed = 2.0f;
    public float movementSpeed = 5.0f;

    private float verticalRotation = 0f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            RotacionarCamera(mouseX, mouseY);
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        MoverJogador(horizontal, vertical);
    }

    void RotacionarCamera(float mouseX, float mouseY)
    {
        player.Rotate(Vector3.up * mouseX * rotationSpeed);

        verticalRotation -= mouseY * rotationSpeed;
        verticalRotation = Mathf.Clamp(verticalRotation, -80f, 80f); 
        transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }

    void MoverJogador(float horizontal, float vertical)
    {
        Vector3 direction = player.forward * vertical + player.right * horizontal;
        direction.Normalize();

        player.Translate(direction * movementSpeed * Time.deltaTime, Space.World);
    }
}
