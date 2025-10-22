using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro namespace

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("UI References")]
    public TMP_Text roomTitleText;  // TextMeshPro for room title
    public TMP_Text storyText;      // TextMeshPro for story content
    public Button previousButton;
    public Button nextButton;

    [Header("Camera")]
    public CameraMovement cameraMovement;

    private int currentRoom = 0;

    // Room data
    private string[] roomTitles = new string[]
    {
        "LIVING ROOM",
        "DINING ROOM",
        "BEDROOM"
    };

    private string[] roomStories = new string[]
    {
        "You wake up in the living room. Everything seems familiar yet strange. On the table is a note: 'The journey begins...'",
        "The dining room stretches ahead. A journal lies open on the table. You read carefully, piecing together the story...",
        "You enter the bedroom. The final clues await here. Your reflection in the mirror seems to be watching you..."
    };

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void StartGame()
    {
        currentRoom = 0;
        UpdateRoomDisplay();
        UpdateButtonStates();
    }

    public void NextRoom()
    {
        if (currentRoom < roomTitles.Length - 1)
        {
            currentRoom++;
            cameraMovement.MoveNextRoom();
            UpdateRoomDisplay();
            UpdateButtonStates();
        }
    }

    public void PreviousRoom()
    {
        if (currentRoom > 0)
        {
            currentRoom--;
            cameraMovement.MovePreviousRoom();
            UpdateRoomDisplay();
            UpdateButtonStates();
        }
    }

    private void UpdateRoomDisplay()
    {
        roomTitleText.text = roomTitles[currentRoom];
        storyText.text = roomStories[currentRoom];
        Debug.Log($"📖 Displaying: {roomTitles[currentRoom]}");
    }

    private void UpdateButtonStates()
    {
        previousButton.interactable = (currentRoom > 0);
        nextButton.interactable = (currentRoom < roomTitles.Length - 1);
    }
}
