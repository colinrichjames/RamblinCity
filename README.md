# Ramblin’ City

**A 3D "Game Feel" Open-World Experience**

## Project Overview

**Ramblin’ City** is an immersive 3D open-world game developed in Unity that prioritizes "Game Feel"—ensuring every interaction is continuous, dynamic, and responsive. Players take on the role of a Tech Titan embarking on a journey to save the city from a hostile takeover by a swarm of mutated yellow jackets and a formidable Boss Bee.

The narrative follows the player’s partnership with **Dr. Marcus** and his assistant **Maya Wong**. To succeed, players must explore hidden sectors of the city, navigate complex environments via foot or vehicle, and manage resources like health-regenerating potions and Coca-Cola cans to survive encounters with hostile entities.

## Core Features & Gameplay Mechanics

### 3D Game Feel & Player Control

The project focuses on high-fidelity character control. Utilizing **Mecanim root motion**, the Tech Titan features fluid, humanoid animations that react instantly to user input with low latency.

* **Dynamic Locomotion:** Players can walk, run, and perform variable-height jumps or "super jumps" based on button hold duration.
* **Vehicular Integration:** An interactive car system, managed via a custom **CarController**, allows for rapid traversal across the open-world map. The transition between foot and vehicle is handled seamlessly through a **Cinemachine** camera brain.
* **Combat Systems:** Features a blend of melee combat (punches and swats) and ranged mechanics utilizing a hidden pesticide gun required for the final boss encounter.

### Intelligent NPC & Steering Behaviors

The world is populated with AI agents that exhibit complex state-driven behaviors, including:

* **Hostile Entities:** Bees and bulldogs feature tiered difficulty. While bees follow patrol paths, the Boss Bee utilizes advanced projectile logic and high-health scaling.
* **Friendly NPCs:** Dr. Marcus and Maya Wong guide the player through a multi-stage **Quest Manager** system, providing narrative context and resource management (the Potion Store).

### Spatial Simulation & Environment

We synthesized a unique environment tailored to the character's abilities. The world is built with consistent Newtonian physics, ensuring that movement and collisions feel grounded.

* **Interactive Elements:** The environment acknowledges the player through proximity-based events, such as swaying vegetation and physics-based obstacle pushing.
* **Boundaries:** The playable space is naturally confined by terrain (hills and mountains), preventing "negative infinity" falls and maintaining immersion.

## Technical Contributions (Unity & C#)

| Feature | Primary Developer(s) | Key Scripts/Systems |
| --- | --- | --- |
| **Character & Vehicle** | Colin, Emily, Tianyi | `CarController`, `PlayerMovement`, `RootMotion` |
| **Quest & State Mgmt** | Colin | `QuestManager`, `PauseMenuToggle`, `GameStarter` |
| **AI & Combat** | Emily | `BeeMovement`, `BossBeeAI`, `HealthBarSystem` |
| **Dialogue & Navigation** | Tianyi | `DialogueSystem`, `MinionAI`, `ObstaclePush` |

## Controls

* **Movement:** `WASD`
* **Jump / Brake:** `Space` (Hold for Super Jump)
* **Interact (Car/NPC):** `E`
* **Combat:** `T` (Punch), `U` (Swat), `F` (Pesticide Gun)
* **Menu:** `Esc`

## Performance & Polish

The game features a unified aesthetic with a consistent color palette and a cohesive soundscape. We implemented an aesthetic UI with a functional start menu, in-game pause system, and "God Mode" for testing. Audio feedback is coupled with physical interactions, providing one-shot sounds for collisions, footsteps, and item collection.
