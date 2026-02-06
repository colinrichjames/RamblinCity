# RAMBLIN CITY

## Description

Description
In our game, players embark on an extraordinary journey set against the backdrop of Ramblin' City, a bustling urban landscape inspired by the spirit and innovation of Georgia Tech. 
Throughout the journey, players encounter obstacles and adversaries, including alien invaders and corrupted factions within the city. 
The game emphasizes the importance of education and collaboration, with the university serving as a central hub for knowledge and resistance against the alien threat.
By freeing the school, players not only safeguard the city's future but also embody the values of resilience, courage, and unity in the face of adversity.
Along the way, players must protect vital assets and fend off threats from hostile entities like the Yellow Jackets and Bulldogs.
As players explore and liberate key landmarks like the university, they gradually build an army and rally allies to their cause. 
The ultimate showdown culminates in a battle against the main alien antagonist, who has manipulated and turned the city's inhabitants against the player. 


### Unity & Division Members

- [Colin James](https://github.gatech.edu/cjames79)
- [Emily Han](https://github.gatech.edu/yhan392)
- [Tianyi Chen](https://github.gatech.edu/tchen397)

### Start scene file
The game starts with the IntroScene scene and the game will automaticaly go through all the scenes below. 

IntroScene 
GameMenuScene
SampleScene
CreditScene

### How to play and what parts of the level to observe technology requirements

Main Controls 

| Action           | Controls     |
| ---------------- | ------------ |
| Character/Car Movement         | wasd keys        |
| Character Swatting Action      | u key        |
| Character Punch Action         | t key        |
| Character Jump Action/Car Break Action          | spacebar key    |
| Character Super Jump Action | hold spacebar key |
| In Game Menu           | esc key        |
| Interaction (dialogues, car, doors)        | e key         |
| Fire Pesticide Gun           | f key        |

How to play the game?
1. Find Dr. Marcus to get the first clue
2. Collect diamonds to get the keyboard
3. Find Maya Wong to get more game information
4. Player can use keyboard to kill bees around the campus to collect more diamonds
5. Player can drive Maya's car to explore the campus
6. Find three bulldogs and elimate them to unlock an information card in Maya store
7. Find the pesticide gun to fight with the final boss bee
8. Player can pick up Coca Cola cans to regenerate energy
9. Eliminate the final boss to win the game
10. Player can equip the weapons and use potions from Inventory menu that can be accessed from In-game menu
11. Player can buy energy boost drinks and unlock important information from Maya store

### Known problem areas
1. Car will randomly hit some invisible colliders around the map. So if the user experiences this, they just need to back up the car using the s key and go around the invisible collider. 
2. Sometimes in combat, the character will get animation locked due to being stunned or completing an action and being stuned at the same time. If the user experiences this, they can break out of the animation lock by moving or not doing any more actions. Sometimes if a action key is held down, the animation lock will persist. 

## Features
1. Combat with enemy NPCs that patrol the world using AI navigation mesh 
2. NPC will drop loot currency when killed to reward players 
3. Ability to use different weapons such as meele and ranged   
4. Ability to drive vehicles to speed up navigation of the large map 
5. Interactable inventory for collection diamonds, weapons, energy consumables 
6. Interactions with characters through dialogue boxes, opening doors, collecting objects, etc... 
7. God mode for testing wher the player health becomes infinite 
8. World consumables to regenerate health to encourage players to take more risks by mitigating consequences   
9. Open world concept feel to enhance the emersion of the game 
10. Quest guidance system that always tells the player what they should be doing at any given time 
11. RPG Style music that plays throughout the game and changes on certain triggers to enhance emersion and affect mood of the player  
12. Footstep sounds for when the character is moving 
13. NPCs will have sounds such as buzzing for bees to provide enhanced audio experience   
14. Explorable buildings 
15. Gated quests to prevent players from losing focus of certain goals 
16. Start menu, tutorial menu, in game menus to support the player 


## It must be a 3D Game Feel game! (5 pts)

### You have implemented a 3D Game that can be defined as a Game Feel game (Colin, Emily, Tianyi)
The game is a 3d game that is defined as game feel game because we implemented evrything using 3D objects. We also took advantage of 3D object colliders and the physics engine to create the game feel for this game. All of the open world NPCs can be interacted with and fought. This means that the world is a living 3D world that provides danger and excitment to the user. We also have intuitive controls for the user to nagivate the 3D world. We have 3D jumping puzzles that can be solved by interacting with 3D objects. The world itself provides emersion throguh many aspects such as the ability to fight NPCs, interact with objects such as doors/vehicles/ coke cans/ diamonds. There is also an inventory system that allows users to collect 3D objects and use them as currency.  

### Clearly defined, achievable, objective/goal? (E.g. player can complete, or alternatively fail at, a level. NOT a sandbox) (Owner: Colin, Emily, Tianyi)
We have an engaging story to guide the player throughout the game. We have implemented a quest system so that the user never loses focus of what they need to do. Certain quests are gated so that a player cannot move on until they complete the quest. The player can fail quests if they die, so there is risk involved with the actions that they take. Therefore, quests are not sandboxed and players run the risk of failing, if they do not keep their health above 0. The open world concept allows players to explore the world and go back to the linear quest system whenever they choose. 

### Communication of success or failure to player! (Owner: Colin, Emily, Tianyi)
1. We have rewards for when player kills an NPC since the NPC will have a death animation. Some NPCs will also drop diamonds on death which rewards the player for their success. 
2. Players can die in the game when their health reaches 0. This is clearly marked by their health bar which is visible at all times. 
3. Quests are succesfully completed when the quest system changes objectives and NPCs will tell the user that they completed a quest through quest dialogue. 
4. Player can unlock information card through Maya's inventory which is a success driven criteria since the cards are locked until an objective is completed. 
5. Weapons can be added to the players inventory by completing quests which rewards the player for their sucessful completion of quests. 
6. Killing the final boss will also change the music track to a victory track which allows the players to know that they are successful. 

### Start menu to support Starting Action? (Owner: Colin)
We have implemented both a start menu and in-game menu. In the start menu, the user can start the game using the "Play" button. They can also view controls by clicking the "tutorial" button. Lastly they can quit the game by pressing the "exit" button. 

Colin Scripts: GameQuitter,GameStarter
Emily Scripts: Tutorial

### Able to reset and replay on success or failure (e.g. In Minecraft when “You died”, there is a “respawn” button) (Owner: Colin)
Upon death, the player will experience a 3 second death scene and then the game will load the start game scene. This allows a player to restart the game. The player can also press the esc key to open the in game menu where there is a "restart" button if they don't feel like waiting. The restart button can also be used if the player just wants to restart the game for any reason.  
Colin scripts: GameQuitter, GameStarter
Emily scripts: Player

### Sorry, no first-person perspective games (e.g. FPS) unless briefly used for  a special action like a sniper rifle or photography game mechanic.(Owner: Colin, Emily, Tianyi)
There is no first-person camera. We have a Cinemachine Brain added to the main camera that allows the the user to change the view of the camera with the mouse. 

## Precursors to Fun Gameplay (20 pts)

### Goals/sub-goals effectively communicated to player (Owner: Colin, Emily, Tianyi)

We have a quest system that clearly outlines to the player each and every goal that they need to do. We found through playtesting that players really needed to know what to do in a short concise manner that can be refferenced quickly. 

The folowing is the quests that we communicate to the player for the main goals. 

1. Find Dr. Marcus
2. Help Dr. Marcus find 12 diamonds 
4. Find Maya Wong to get more game information and help 
6. Kill the bulldog 
7. Find pesticide gun to kill last boss 
8. Kill the final boss

Subgoals/Optional actions are communicated not as bluntly through quests. We use dialogue and context instead. 
1. Using the car 
2. Buying inventory items from maya 
3. Collecting diamonds to use as currency 
4. Collect coke cans to receive back health 

Tianyi Scripts: Dialogue, PlayerInventory,EnableKeyboard,Diamond,InventoryUI
Emily Scripts: MayaDialogue,CloseWindow,Energy,healthbar DisplayItem,PurchaseItem,ShowInventory,UseInventory  
Colin Scripts: CarController, QuestManager,GettingInAndOutOfCar

### Your game must provide interesting choices to the player (Owner: Colin, Emily, Tianyi)
Tech Titan can perform many tasks throughout the game.
1. Interact with Dr. Marcus Carter and Maya to advance the story
2. Fight bees/bulldogs/boss bee and other NPCs
3. Collect diamonds to buy inventory items from maya 
4. Collect coke cans to replenish health 
5. Use the car to traverse the map 
6. Choose to explore the map and defocus the main quests

Tianyi Scripts: Dialogue, PlayerInventory,EnableKeyboard,Diamond,InventoryUI
Emily Scripts: MayaDialogue,CloseWindow,Energy,healthbar DisplayItem,PurchaseItem,ShowInventory,UseInventory  
Colin Scripts: CarController, QuestManager,GettingInAndOutOfCar

### Your player choices must have consequences (dilemmas) (Owner: Emily, Tianyi)
1. When the user gets damage from the enemies they can die. 
2. They must stay away or fight the enemies. 
3. 
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
Rewards can come from Dr. Marcus Carter. Punishment comes from reduced health from the enemies. The user will get powerups when the collect the coca-cola. 

### In-game learning/training opportunities (e.g. gate restricts player to safe  area until basic proficiency in new skill is demonstrated, etc.)(Owner: Colin, Emily, Tianyi)
The user will be able to drive the car pressing E later in the game. The car will start invisible and once they complete a certain task for Dr. Carter they will gain access to the car keys. 
Colin: CarController 

### Appropriate progression of difficulty (Owner: Colin, Emily, Tianyi)
the bees patrolling the map deliver less damage and are easier to kill. Once the player gets close to Tech Tower they will engage the Alien Bee which has projectiles, has more health, and is harder to kill with the pesticides. 

### Avoid opportunities for players to trivially beat your game challenges.  That means playtesting to observe emergent strategies that might break your game! (Owner: Colin, Emily, Tianyi)
We will be able to playtest the game in the next phase of the project. 

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
Colin Scripts: CarController


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
This will be implemented in polish phase

### Note that using existing 3d Party camera scripts is acceptable. But you must configure/modify to suit the unique needs of your game (Owner: Tianyi - main camera cinemachine brain)
We configured and modified the camera scripts to suit the unique needs of our game. 
### Auditory feedback on character state and actions (e.g. footsteps, landing, collisions, tire squeal, engine revs, etc.) (Owner: Tianyi - background sound, tech titan footsteps Emily - bee sound)
We have added footsteps the the character and background music

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
We were able to implement a start menu GUI, the game feels like a game from start to finsh, there is no debig output. 
There is an in-game pause menu wiht the ability to quit game. There is also a quit game button on every scene. You can also skip the intro scene to the game scene, where the game can be exited from. 
God button is added to the game menu and the game menu can be accessed from pressing the escape key. It is well hidden and so the user must actively seek it out to press it. 

Asset/Library Licensing:

    1. Card shirts lite  https://assetstore.unity.com/packages/2d/gui/card-shirts-lite-165698

    2. Cola can  https://assetstore.unity.com/packages/3d/cola-can-96659

    3. Elemental potions  https://assetstore.unity.com/packages/2d/gui/icons/elemental-potions-175338

    4. Fantasy Bee  https://assetstore.unity.com/packages/3d/characters/animals/fantasy-bee-135487

    5. Paint Gun  https://assetstore.unity.com/packages/3d/props/tools/paint-gun-75672

    6. PKS_Laptop_low  https://assetstore.unity.com/packages/3d/props/pks-laptop-low-264665

    7. SimplePloy city  low poly assets  https://assetstore.unity.com/packages/3d/environments/simplepoly-city-low-poly-assets-58899

    8. Street bench  https://assetstore.unity.com/packages/3d/props/exterior/street-bench-656

    9. Stylized Devil Bulldog  https://assetstore.unity.com/packages/3d/characters/creatures/stylized-devil-bulldog-190895

    10. 371 Simple Buttons Pack  https://assetstore.unity.com/packages/p/371-simple-buttons-pack-97516

    11. 3D Simple House Maker Kit  https://assetstore.unity.com/packages/p/3d-simple-house-maker-kit-249486

    12.Absolutely Free Music  https://assetstore.unity.com/packages/p/absolutely-free-music-4883

    13. Adventure RPG Essentials Music Pack  https://assetstore.unity.com/packages/audio/music/orchestral/adventure-rpg-essentials-music-pack-177827

    14. Fantasy landscape  https://assetstore.unity.com/packages/p/fantasy-landscape-103573

    15. Fantasy Skybox FREE  https://assetstore.unity.com/packages/p/fantasy-skybox-free-18353

    16.  Footsteps  Essentials  https://assetstore.unity.com/packages/p/footsteps-essentials-189879

    17. Free Mining Pack  Low Poly Ores, Gems, Tools & Props  https://assetstore.unity.com/packages/p/free-mining-pack-low-poly-ores-gems-tools-props-189962

    18  Free Trees  https://assetstore.unity.com/packages/p/free-trees-103208

    19. Grass And Flowers Pack 1  https://assetstore.unity.com/packages/p/grass-and-flowers-pack-1-17100

    20. Japanese Garden Pack  https://assetstore.unity.com/packages/p/japanese-garden-pack-179492

    21. Keyboard Adjustable Colors  https://assetstore.unity.com/packages/p/keyboard-adjustable-colors-154305

    22. Medieval barrels and boxes  https://assetstore.unity.com/packages/p/medieval-barrels-and-boxes-137474

    23. Simple Gems Ultimate Animated Customizable Pack  https://assetstore.unity.com/packages/p/simple-gems-ultimate-animated-customizable-pack-73764

    24. Terrain Sample Asset Pack  https://assetstore.unity.com/packages/p/terrain-sample-asset-pack-145808

    25. True Clouds/Fog (Mobile & PC)  https://assetstore.unity.com/packages/p/true-clouds-fog-mobile-pc-107379

    26. Victorian Brick Building  https://assetstore.unity.com/packages/3d/environments/urban/victorian-brick-building-114165

    27. Volumetric Crystal Materials Pack  https://assetstore.unity.com/packages/vfx/shaders/substances/volumetric-crystal-materials-pack-105951

    28. ARCADE: FREE Racing Car https://assetstore.unity.com/packages/3d/vehicles/land/arcade-free-racing-car-161085
    

### Environment Acknowledges Player, Note: there is obvious overlap here with the Spatial Simulation  category above. In regard to polish, we are looking for environment interaction enrichment/appeal, as opposed to impact on core gameplay. Should include many of the following: Scripted aesthetic animations (swaying trees, grass, scurrying bugs under moved rocks, etc.) Proximity-based events (alien plants that retract if you get near, picture frame falls off wall, etc.) Surface effects, such as texture changes or decals (e.g. dentable surface, bullet holes, etc.) Particle effects (e.g. dust or splashes around footsteps) Auditory representation of every observable game event, Physics event-based feedback such as particle effects and one-shot audio for collisions of different types, Sonifications that map physical properties to audio effects. Example: Wheeled robot gear whine generated via volume attenuation and frequency shift of looped audio as a function of robot’s speed (Owner: Colin, Emily, Tianyi)
We were able to have the environment acknowledge the player. The enviroment interacts with the player. 

### Cohesiveness / Unified Aesthetic, Artistic style (extremely simple is fine! But be consistent and thoughtful), Shading and lighting style, Unified color palette throughout game, Sound theme, including consonance (also avoid monotonous effects) (Owner: Colin, Emily, Tianyi)
There is a cohesiveness throughout the game. We have the style and terrain going through the whole game. 

### Appeal - No glitches, No easily escaping the confines of the game world (make proper and plausible barriers), No obvious edge of the game world unless part of intended , gameplay (e.g. a quad for a ground plane that the player can see where they fall off the world), No getting the player stuck Stable (e.g. should play consistently the same on variety of  hardware) (Owner: Colin, Emily, Tianyi)
The game has no glitches, you cannot go off the map past the mountains, there is no obvious edge of the game. 
