# House Tour Unity Project

## Overview
This is a mini-game developed in Unity that lets players explore a 3D house environment. Players navigate through rooms, interact with the story, and follow a guided experience using an intuitive UI menu and smooth camera transitions.

The project demonstrates Unity UI management, camera movement with DOTween, and basic storytelling mechanics.

---

## Features

### Main Menu & Navigation
- Welcome screen with Play button
- Instructions page
- Credits page
- Return to menu functionality

### Gameplay
- Explore 3 rooms: Living Room, Dining Room, Bedroom
- Smooth camera movement between rooms
- Room-specific story content updates dynamically
- Previous and Next buttons for moving between rooms
- Quit game functionality

### Storytelling
- Each room has unique story text displayed via TextMeshPro
- Player progresses through a mini-story as they move through rooms

### Camera
- Camera transitions use DOTween for smooth movement and rotation
- Prevents free camera movement until game starts

---

## Screenshots / GIFs
*(Optional: Add a few screenshots or GIFs of your game in action)*

Example:
```markdown
![Main Menu](screenshots/main_menu.png)
![Living Room](screenshots/living_room.png)
![Bedroom](screenshots/bedroom.png)
```

---

## Installation / Play Instructions

1. **Clone the repository:**
```bash
   git clone https://github.com/yourusername/house-tour-unity.git
```

2. **Open the project in Unity Hub.**

3. **Open the scene** `MainScene` (or your main scene file).

4. **Press Play** to run the game in the Unity Editor.

5. **Use the UI buttons to navigate:**
   - `Play` → Start the experience
   - `Next` / `Previous` → Move between rooms
   - `Return to Menu` → Go back to the main menu
   - `Quit` → Exit the game

---

## Dependencies

- **Unity 2023.1** or newer
- **DOTween** (free Unity plugin for tweening animations)
- **TextMeshPro** (for UI text)

---

## Project Structure
```
Assets/
├─ Scenes/
│  └─ MainScene.unity
├─ Scripts/
│  ├─ CameraMovement.cs
│  ├─ GameManager.cs
│  └─ MenuManager.cs
├─ Prefabs/
├─ UI/
│  ├─ MenuCanvas.prefab
│  └─ GameCanvas.prefab
└─ Materials/
```

---

## Authors / Contributors

- **Branice Kazira** – Developer & Designer

---

## Demo

- **WebGL Playable:** http://localhost:60377/
- **Gameplay Video:** https://drive.google.com/file/d/1XDFtJxFZ5IVFQfLGm0ChO1e8UtWb6jtx/view?usp=sharing


---

## License

*(Optional: Add your license information here, e.g., MIT License)*

---

## Acknowledgments

*(Optional: Credit any tutorials, assets, or resources you used)*

- DOTween by Demigiant
- Unity Technologies

---

*Last Updated: October 23, 2025*
