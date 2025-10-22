using UnityEngine;
using DG.Tweening;

public class CameraMovement : MonoBehaviour
{
    public Transform[] rooms;
    public float moveTime = 2f;
    private int currentRoomIndex = 0;

    [Header("Free Movement")]
    public float moveSpeed = 5f;
    public float lookSpeed = 2f;
    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        if (rooms.Length == 0)
        {
            Debug.LogError("⚠️ No rooms assigned!");
            return;
        }

        transform.position = rooms[0].position;
        transform.rotation = rooms[0].rotation;
    }

    void Update()
    {
        // Free movement inside room
        float h = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float v = Input.GetAxis("Vertical");   // W/S or Up/Down

        transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * v * moveSpeed * Time.deltaTime);

        // Mouse look
        rotationX += Input.GetAxis("Mouse X") * lookSpeed;
        rotationY -= Input.GetAxis("Mouse Y") * lookSpeed;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationY, rotationX, 0f);
    }

    public void MoveNextRoom()
    {
        if (currentRoomIndex < rooms.Length - 1)
        {
            currentRoomIndex++;
            MoveToRoom(currentRoomIndex);
        }
    }

    public void MovePreviousRoom()
    {
        if (currentRoomIndex > 0)
        {
            currentRoomIndex--;
            MoveToRoom(currentRoomIndex);
        }
    }

    private void MoveToRoom(int index)
    {
        Transform target = rooms[index];
        transform.DOKill();

        // Tween to new room
        transform.DOMove(target.position, moveTime).SetEase(Ease.InOutSine);
        transform.DORotateQuaternion(target.rotation, moveTime).SetEase(Ease.InOutSine);

        Debug.Log("📷 Moving to room " + index);
    }
}
