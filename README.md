# RAMBLING CITY

## Description

Description
Welcome to ramblin’ city!

Tech titan embarks on an extraordinary journey set against the backdrop of rambling’ city. Throughout the journey, players encounter obstacles including corrupted groups within the city. Doctor Marcus has been fighting threats with is assistant Maya Wong. They need your help! You will set out on missions to find diamonds and discover hidden areas of ramblin’ city. Along the way, players must fend off threats from hostile entities like swarms of yellow jackets. Whenever you need help, doctor Marcus and Maya Wong are here to provide assistance. Maya Wong will be a key componet of your success as you visit her store and seek her advice. She can tell you different missions you can accomplish to progress in the world. Whenever you are in trouble you can purchase potions from Maya Wong to regenerate your health.You can explore the world by using Maya Wong’s car. You will also encounter bulldogs that pose a threat to ramblin’ city. When you are in trouble you can use coca-cola cans to regenerate your health. The ultimate showdown culminates in a battle against the bee who has taken over the city. You must first find the hidden pesticide gun to be able to accomplish this mission. Good luck saving ramblin’ city!

### Unity & Division Members

- [Colin James](https://github.gatech.edu/cjames79)
- [Emily Han](https://github.gatech.edu/yhan392)
- [Tianyi Chen](https://github.gatech.edu/tchen397)

### Start scene file
IntroScene

### How to play and what parts of the level to observe technology requirements
control the character using WASD. Jump / Break (in car): Space bar. Super jump: hold space bar. melee punch: T. Melee Swat: U. Shoot pesticide gun: F. Interact: E.

### Known problem areas
All bugs fixed. No known problem areas at time of submission.

## Features

## It must be a 3D Game Feel game! (5 pts)

### You have implemented a 3D Game that can be defined as a Game Feel game (Colin, Emily, Tianyi)
The game is a 3d game that is defined as game feel. This game is open world but has a guided objective. 

### Clearly defined, achievable, objective/goal? (E.g. player can complete, or alternatively fail at, a level. NOT a sandbox) (Owner: Colin, Emily, Tianyi)
The goal of the game is clearly defined and achievable. The overall goal is found in the description above. 

### Communication of success or failure to player! (Owner: Colin, Emily, Tianyi)
The player has a health bar. As the user takes damage from the bees and bulldog they will decrease their health

### Start menu to support Starting Action? (Owner: Colin)
We have implemented both a start menu and in-game menu. In the start menu, the user can start game, select god mode, or quit game. In the in-game menu, the user will press the "esc" key to activate the menu. They can select from options including restart game, exit game, and god mode.

Colin Scripts: Pause Menu Toggle, GameQuitter,GameStarter

### Able to reset and replay on success or failure (e.g. In Minecraft when “You died”, there is a “respawn” button) (Owner: Colin)
Death logic was added when the health of Tech Titan reaches zero. The player animation will fall on the ground and the user will return to the start screen to restart from the home menu. 

### Sorry, no first-person perspective games (e.g. FPS) unless briefly used for  a special action like a sniper rifle or photography game mechanic.(Owner: Colin, Emily, Tianyi)
There is no first-person camera. We have a Cinemachine Brain added to the main camera that allows the the user to change the view of the camera with the mouse. 

## Precursors to Fun Gameplay (20 pts)

### Goals/sub-goals effectively communicated to player (Owner: Colin, Emily, Tianyi)
Each of the quests throughout the gameplay is communicated to the player through the Quest dialogue UI
Task 1: interact with Dr. Marcus
Task 2: Find the Diamonds
Task 3: Find Maya Wong
Task 4: Eliminate the bulldog 
Task 5: Find the pesticide gun
Task 6: Eliminate the boss bee


Tianyi Scripts: Dialogue
Emily Scripts: MayaDialogue
Colin Scripts: QuestManager

### Your game must provide interesting choices to the player (Owner: Colin, Emily, Tianyi)
Tech Titan can perform many tasks throughout the game. He can talk with Dr. Marcus carter, talk with Maya Wong, fight bees by punching, and fight the boss by using the pesticide gun, he can drive the car around the map. 

Tianyi Scripts: Dialogue, PlayerMovement, Obstacle Push
Emily Scripts: MayaDialogue, Pick Gun, PlayerMovement
Colin Scripts: CarController

### Your player choices must have consequences (dilemmas) (Owner: Emily, Tianyi)
When the user gets damage from the enemies they can die. They must stay away or fight the enemies. Quests from Dr Marcus 
Emily Scripts: Player, Bee, 
Tianyi Scripts: ObstaclePush,

### Player choices engage the player with the game world (e.g. buttons, climbable ledges, gun turrets, computer terminals, vehicles, etc.) and  inhabitants (AI-controlled agents) (Owner: Emily - AI Combat, Tianyi - AI Navigation)

Tianyi Scripts: MinionAI 
Emily: Bee Movement, BossBee, BossBeeMovement

### Avoid Hollow, Obvious, and Uninformed Decisions (Owner: Colin, Emily, Tianyi)
The player avoids hollow, obvious, and uninformed decisions

### Avoid Fun Killers (micromanagement, stagnation, insurmountable obstacles, arbitrary events, etc.) (Owner: Colin, Emily, Tianyi)
The player avoids fun killers including micromanagement, stagnation, insurmountable obstacles, and arbitrary events

### Your game should achieve balance (balance of resources, strategies, etc., as appropriate) (Owner: Colin, Emily, Tianyi)
The game achieves balance of resources and strategies.

### Reward successes, and (threat of) punishment for failure (Owner: Tianyi - Dr. Carter and Gem collection, Emily: AI combat and health bar)
Rewards can come from Dr. Marcus Carter including the keyboard. When the bees are killed they drop diamonds. The coke cans can be collected and replenish health. Maya Wong provides guidance to future quests. Punishment comes from reduced health from the enemies. The user will get powerups when the collect the coca-cola. 

### In-game learning/training opportunities (e.g. gate restricts player to safe  area until basic proficiency in new skill is demonstrated, etc.)(Owner: Colin, Emily, Tianyi)
The user will be able to drive the car pressing E later in the game. The car is located next to Maya Wong and they need to complete the mission for Dr. Marcus before they can access that piece of the map.
Colin: CarController 

### Appropriate progression of difficulty (Owner: Colin, Emily, Tianyi)
the bees patrolling the map deliver less damage and are easier to kill. The bulldogs are significantly harder to kill than the bees. Once the player gets close to Tech Tower they will engage the boss Bee which has projectiles, has more health, and is harder to kill with the pesticides. 

### Avoid opportunities for players to trivially beat your game challenges.  That means playtesting to observe emergent strategies that might break your game! (Owner: Colin, Emily, Tianyi)
We were able to playtest our game and avoid opportunities for players to trivially beat our game challenges. 

## 3D Character/Vehicle with Real-Time Control (20 pts)
### Based on skills learned in Character Control Milestone (Owner: Colin, Emily, Tianyi)
We are able to control the character using root motion. The Character control script is added to Tech Titan. We also have a car control script added to the car. 
Tianyi Scripts: PlayerMovement
Emily Scripts: PlayerMovement, YoungMayaMovement
Colin Scripts: CarController

### Character control is a predominant part of gameplay and not simply a way to traverse between non-“Game Feel” interactions. (e.g. walking between different point-and-click puzzles.) (Owner: Tianyi - Tech Titan walking and animations, Emily: Tech Tian punching and gun, Maya Wong animations, bee animation)
Tech titan is able to walk across the entire map freely. In this "open-world" style game he can walk, run, jump, drive the car, collect gems, collect coca-cola bottles, fight the bees, and spray the boss with pesticides. 

Tianyi Scripts: Dialogue, PlayerMovement, Obstacle Push, Player Inventory
Emily Scripts: MayaDialogue, Pick Gun, PlayerMovement
Colin Scripts: CarController, QuestManager


### No Unity tutorial characters or CS4455 milestone characters allowed. You must use characters other than those in tutorials; that  includes the “3DGameKit” (Owner: Colin, Emily, Tianyi)
We have not included Unity tutorial characters of milestone chracters. 

### Your character is not a complete prepackaged asset from a 3rd party. It is ok to use models and animations from another source, but your team should configure animation control and input processing (Owner: Colin, Emily, Tianyi)
Our character is not a complete prepackages asset from a 3rd party. 

### Utilize a character/vehicle controlled by the player with engaging animations that react to the player’s inputs. Examples: a humanoid skeletal animated character animated via Mecanim that blends between  different animations based on the player’s inputs. Or perhaps a vehicle with moving wheels controlled by a throttle input and moving suspension and driver’s head that turns, etc. (Owner: Colin)
Tech Titan has the PlayerMovement Script and the car has the CarController script. Both of these are the controller scripts for th eplayer and car. The vehicle has moving wheels controlled by a throttle input (wasd keys, moving suspension). The user can get in and out of the car by pressing the "e" key. Tech Titan can move with WASD. Punch with T, Swat with U, jump with space, super jump  holding space, walk by holding shift. 

Tianyi Scripts: Dialogue, PlayerMovement, Obstacle Push
Emily Scripts: Pick Gun, PlayerMovement, YoungMayaMovement
Colin Scripts: CarController

### Player has Game Feel style control: continuous, dynamic, low latency, variable/analog-style control of character movement majority of time (ideally support a popular analog controller like PS4) Examples: analog  stick movement, Mario’s variable jump height from button hold duration, modifier-button control of a speed boost (Owner: Colin, Emily, Tianyi)
The Player has Game Feel style control: continuous, dynamic, low latency, variable/analog-style control of character movement majority of time. The user can get in and out of the car by pressing the "e" key. Tech Titan can move with WASD. Punch with T, Swat with U, jump with space, super jump  holding space, walk by holding shift. 

Tianyi Scripts: , PlayerMovement
Emily Scripts: PlayerMovement, YoungMayaMovement
Colin Scripts: CarController

### Choice of controls is intuitive and appropriate (e.g. shouldn’t make difficult button mappings or controls where it is unnecessarily difficult to interact) (Owner: Colin, Emily, Tianyi)
The choice of controls is intuitive and appropriate. 

Tianyi Scripts: Dialogue 
Emily Scripts: MayaDialogue 
Collin Scripts: CarController

### Fluid animation. Continuity of motion (no instantaneous pose changes, no glitching, unintended teleporting, a ground-based character stuck floating in air, etc.) (Owner: Colin, Emily, Tianyi)
There is fluid animation. The motion is continuous. Ther is no instantaneous pose changes, no glitching, and no unintended teleporting.

### Humanoid characters should not slide or moonwalk. Use root motion, possibly with IK corrections! (Owner: Tianyi - Tech Titan root motion, Emily - Maya wong root motion)
The humanoid characters do not slide or moonwalk. We were able to use root motion. 

### Aim for low latency responsiveness to control input (Owner: Colin, Emily, Tianyi)
There is low latency responsiveness for control input

### Camera is smooth, always shows player and obstacles in a useful way,  automated following of character or intuitively controllable as appropriate 
The camera is smooth, always shows player and obstacles in a useful way, and automated following of character or car with intuitive controls using wasd. The camera switches between the car and player by pressing E

### Camera has limited passing through walls, near clipping plane cutting  through objects (e.g. player model), etc. (Owner: Colin, Emily, Tianyi)
The camera has limited passing through walls

### Note that using existing 3d Party camera scripts is acceptable. But you must configure/modify to suit the unique needs of your game (Owner: Tianyi - main camera cinemachine brain)
We configured and modified the camera scripts to suit the unique needs of our game. 
### Auditory feedback on character state and actions (e.g. footsteps, landing, collisions, tire squeal, engine revs, etc.) (Owner: Tianyi - background sound, tech titan footsteps Emily - bee sound)
We have added footsteps the the character and background music. There is sounds when the coke cans and diamonds are picked up. 

### Coupling with physics simulation via animation curves, animation callback events, handoff to ragdoll simulation, IK adjustments to animations, vehicle that breaks up in wrecks, etc (Owner: Colin, Emily, Tianyi)
We were able to couple the physics simulation through animation curves and callback events. 


## 3D World with Physics and Spatial Simulation (20 pts)
### Based on skills learned in Physics Milestone (Owner: Colin, Emily, Tianyi)
We implemented the 3D world with physics and spatial simulation based on skills learned in physics milestone

### You have synthesized a new environment rather than just use a downloaded level from the asset store. You can certainly make use of 3rd party assets, architecture, terrain, etc., but you must synthesize a unique environment tailored to your character’s abilities and the game challenges you wish to support. (Owner: Colin, Emily, Tianyi)
We synthesized a new environment rather than just use a download level from the asset store. 

### Both graphically and auditorily represented physical interactions. Consider every single cause and effect interaction and make sure there is associated audio (Owner: Colin, Emily, Tianyi)
physical interactions are represented both graphically and auditorily

### Graphics aligned with physics representation (e.g. minimal clipping through objects) (Owner: Colin, Emily, Tianyi)
The graphics are aligned with physics representation

### Appropriate boundaries to confine player to playable space (players should never encounter avatar falling to negative infinity or escaping the  level; use invisible colliders and death zones when necessary) (Owner: Emily, Tianyi)
There are appropriate boundaries to confine players to playable space. The hills contain the user into the scene. 

### A variety of environmental physical interactions possibly including: Interactive scripted objects (buttons that open doors, pressure plates, jump pads, computer terminals, etc.) Simulated Newtonian physics rigid body objects (crates, boulders, detritus, etc.) Animated objects using Mecanim (can be used for non-humanoid  animations too!), programmatic pose changes, kinematic rigid body settings, etc. (moving platforms, machinery gears, gun turrets, etc.) (Owner: Tianyi)
The user is able to push the boxes, the trees move when you get close
Tianyi scripts: obstacle push 

### State changing or destroyable objects (glass pane that shatters, boulder that breaks into bits, bomb that blows up, etc.) (Owner: Colin, Emily, Tianyi)
You are able to kill the bees and they will disappear 
Emily Scripts: Bee, BeeMovement

### 3D simulation with six degrees of freedom movement of rigid bodies (Owner: Colin, Emily, Tianyi)
3D simulation is used in the game 

### Interactive environment (Owner: Colin, Emily, Tianyi)
The player is able to interact with the environment
Tianyi scripts: obstacle push 
Emily Scripts: Energy

### Consistent spatial simulation throughout (e.g. Running speed remains same regardless of framerate. gravity constrains maximum jump distance; shouldn’t be able to jump more or less in different cases unless obvious input control or environmental changes are presented to the user) (Owner: Colin, Emily, Tianyi)
There is consistent spatial simulation throughout the game.

## Real-time NPC Steering Behaviors / Artificial Intelligence (20 pts) 

### Based on skills learned in AI Milestone (Owner: Colin, Emily, Tianyi)
We implemented the skills learned in AI Milestones

### Your agents are not complete prepackaged assets from a 3rd party. It is ok to use models and animations from another source, but your team should configure animation control and AI steering and decision making. Also, don’t use Unity tutorial or CS4455 milestone characters (Owner: Colin, Emily, Tianyi)
Our agents are not complete prepackaged assets from a 3rd party. 

### Multiple AI states of behavior (e.g. idle, patrol, pathfinding, maniacal laughter, attack-melee, attack-ranged, retreat, reload, teeth flossing, etc.) (Emily, Tianyi)
There are multiple AI States.

Tiany Scripts: MinionAI
Emily Scripts: BeeMovement

### Smooth steering/locomotion of NPCs. (Owner: Emily, Tianyi)
There is smooth steering and locomotion of the NPCs. Maya Wong, Dr. Carter, bees, bulldog

### Predominantly root motion for humanoid characters. (Owner: Emily, Tianyi)
We predominantly use root motion for humanoid characters.

### Reasonably effective and believable AI? (Owner: Emily, Tianyi)
There is reasonably effective and believable AI

### Fluid animation. Continuity of motion (no instantaneous pose changes, no glitching, unintended teleporting, character stuck floating in air, etc.)(Owner: Emily, Tianyi)
There is fluid animation in the game. 

### Sensory feedback of AI state? (e.g. animation, facial expression, dialog/sounds, and/or thought bubbles, etc., identify passive or aggressive AI) (Owner: Emily, Tianyi)
There is sensory feedback of AI State

### Difficulty of player engaging the enemy is appropriate? (Owner: Emily, Tianyi)
There is difficulty of player engaging the enemy is appropriate

### Perceived as a fair opponent? You may need to implement a perceptual model for your AI. 
There is a perceived fair opponent. 

### AI interacts with and takes advantage of environment? (presses buttons, takes cover from attack, collects resources, knocks over rigid body objects, etc.) (Owner: Emily, Tianyi)
The AI interacts wiht and takes advantage of the environment

## Polish (15 pts)
### Overall UI, Implement a start menu GUI, Credits and Asset/Library Licensing, Anonymous credit is fine for students that wish (e.g., a fantasy name/handle), Implement in-game pause menu with ability to quit game, Your software should feel like a game from start of execution to the end, There should be no debug output visible (you don’t need a name on the HUD like the individual milestones), Ability to exit software at any time, No “test-mode”/“god-mode” buttons, etc. (OK if accessible via menu option or unlikely-to-press-accidentally button combo like: ↑,↑,↓,↓,←,→,←,→,B,A,SELECT,START), GUI elements should be styled appropriately and consistently, Transitions between scenes should be done aesthetically (e.g. fade in, fade out, panning cameras, etc. (Owner: Colin, Emily, Tianyi)
We were able to implement a start menu GUI
There is an in-game pause menu wiht the ability to quit game. 
There is an ability to exit the software at any time with "god mode" button.
We were able to add credits for the assets used. 

### Environment Acknowledges Player, Note: there is obvious overlap here with the Spatial Simulation  category above. In regard to polish, we are looking for environment interaction enrichment/appeal, as opposed to impact on core gameplay. Should include many of the following: Scripted aesthetic animations (swaying trees, grass, scurrying bugs under moved rocks, etc.) Proximity-based events (alien plants that retract if you get near, picture frame falls off wall, etc.) Surface effects, such as texture changes or decals (e.g. dentable surface, bullet holes, etc.) Particle effects (e.g. dust or splashes around footsteps) Auditory representation of every observable game event, Physics event-based feedback such as particle effects and one-shot audio for collisions of different types, Sonifications that map physical properties to audio effects. Example: Wheeled robot gear whine generated via volume attenuation and frequency shift of looped audio as a function of robot’s speed (Owner: Colin, Emily, Tianyi)
We were able to have the environment acknowledge the player. The enviroment interacts with the player. 

### Cohesiveness / Unified Aesthetic, Artistic style (extremely simple is fine! But be consistent and thoughtful), Shading and lighting style, Unified color palette throughout game, Sound theme, including consonance (also avoid monotonous effects) (Owner: Colin, Emily, Tianyi)
There is a cohesiveness throughout the game. We have the style and terrain going through the whole game. 

### Appeal - No glitches, No easily escaping the confines of the game world (make proper and plausible barriers), No obvious edge of the game world unless part of intended , gameplay (e.g. a quad for a ground plane that the player can see where they fall off the world), No getting the player stuck Stable (e.g. should play consistently the same on variety of  hardware) (Owner: Colin, Emily, Tianyi)
The game has no glitches, you cannot go off the map past the mountains, there is no obvious edge of the game. 
