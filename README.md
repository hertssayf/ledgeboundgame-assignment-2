# Assignment 2 - Sprint 2 Development

This repository continues from the Assignment 1 prototype and expands the project for SD2 Assignment 2. The original commit history has been preserved to show earlier development, while new commits from this point show Sprint 2 updates, testing, backlog reviews and improvements.

---

## 1.0 Brief Introduction
This repository contains the game **LedgeBound** developed for the Software Development 2 module. The project is a 2D platformer game inspired by the hit classic Mario. 

---

<p align="center">
  <img width="300" src="https://i.postimg.cc/3Rm8qn4W/Ledge-Bound-13-03-2026.png">
</p>

<p align="center">
  <b>A 2D Platform Game</b>
</p>

---

## Table Of Contents For Updated Assignment 2 Changes

- [Project Decision](#24-project-decision-2d-side-scrolling-platformer)
- [Project Aim and Objectives](#40-project-aim-and-objectives)
- [Overall Specification](#50-overall-specification--ledge-bound)
- [User and System Requirements](#60-user-and-system-requirements)
- [Overall Design and Development Strategy](#90-overall-design-and-development-strategy)
- [Artwork and Visual Design](#130-artwork-and-visual-design)
- [Gameplay and Core Mechanics](#160-gameplay-and-core-mechanics)
- [State Management](#190-state-management)
- [Programming Language and Platform](#210-programming-language-and-platform)
- [Basic Pseudocode](#240-basic-pseudocode)
- [Project Management Approach](#250-project-management-approach)
- [Testing Strategy](#260-testing-strategy)
- [Evaluation](#270-evaluation)

---

## 2.0 Reviewing Project Ideas

### 2.1 2D Side-Scrolling Platformer
A game where the player moves from left to right through levels, jumping across platforms, avoiding hazards and reaching an end goal.

**Target audience**
- Casual gamers
- Students
- Fans of classic platform games

**Considerations**
- Smooth controls
- Balanced level progression
- Fair obstacle placement
- Clear win and lose conditions

**Pros**
- Suitable for an individual project
- Strong fit for Unity development
- Easy to demonstrate game states, rules and mechanics
- Allows clear testing of movement and collisions

**Cons**
- Platforming movement needs careful balancing
- Collision bugs can affect playability
- Level design takes time to refine

---

### 2.2 Endless Runner
A game where the player survives as long as possible while automatically moving forward and avoiding obstacles.

**Target audience**
- Casual players
- Mobile players
- People who prefer short game sessions

**Considerations**
- Speed balancing
- Obstacle generation
- Score and replayability

**Pros**
- Simple concept
- High replay value
- Easy to understand

**Cons**
- Can become repetitive
- Less opportunity for structured level design

---

### 2.3 Puzzle Platformer
A platform game where the player solves movement-based puzzles to progress.

**Target audience**
- Players who enjoy problem-solving
- More strategic players

**Considerations**
- Puzzle clarity
- Difficulty balancing
- Learning curve

**Pros**
- Adds more depth
- Strong level design focus

**Cons**
- More complex to design
- Harder to keep the project scope manageable

---

### 2.4 Project Decision: 2D Side-Scrolling Platformer
After reviewing the possible project ideas, a 2D side-scrolling platformer was selected as it aligns well with Unity development and provided an opportunity to gain experience using the Unity game engine.
The platformer structure also makes it easier to divide the game into manageable sections such as player movement, hazards, collectibles, level progression, state management and user interface.
It allows the project to demonstrate the Scrum software development lifecycle through requirements analysis, design, backlog planning, implementation, testing and review.

I have created a powerpoint pitch for the game describing essential fundamentals here: [SD2_Platform_Game_Pitch.pptx](./SD2_Platform_Game_Pitch.pptx)

---

## 3.0 Reviewing Target Audience

### 3.1 Casual Gamers
Characteristics:
- Prefer simple controls
- Want enjoyable short play sessions
- Expect quick understanding of the game

### 3.2 Nostalgic Platform Game Fans
Characteristics:
- Familiar with platform games
- Often enjoy nostalgic games inspired by older titles
- Prefer addictive but easy-to-play experiences

### 3.3 Students/Young Adults Aged 18-25
Characteristics:
- Notice movement quality and jump accuracy
- Appreciate fair challenge and good level flow
- Enjoy replayable platforming mechanics

---

## 4.0 Project Aim and Objectives

### 4.1 Aim
To develop a functional 2D side-scrolling platform game in which the player runs, jumps, avoids hazards(including enemies), and reaches the end of each level.

### 4.2 Objectives
- Identify user and system requirements
- Produce scrum-style user stories and a prioritised backlog
- Design the gameplay, levels, characters, environment and UI
- Use Unity and C# to implement the game
- Track development progress using backlog reviews
- Test the game against requirements, functions and features
- Produce a playable prototype suitable for demonstration

---

## 5.0 Overall Specification – LedgeBound

### 5.1 Final Core Feature Requirements

LedgeBound is designed as a 2D side-scrolling platformer prototype where the player controls Dexter, an adventurer who must move across a dangerous level, avoid hazards, interact with enemies and reach the goal flag. The final Sprint 2 prototype focuses on delivering a stable and testable core gameplay loop rather than attempting to include every optional idea from the original plan.

The final core requirements are:

* The player must be able to move left and right using keyboard input.
* The player must be able to jump using a grounded check so jumping feels controlled and fair.
* The level must include platforms, ground terrain, gaps and spike hazards.
* The game must include slime enemies as dynamic obstacles.
* Touching a hazard or enemy must trigger damage, life loss or respawn behaviour.
* Falling below the level must trigger a fail/respawn response.
* The level must include an end goal that triggers the level complete state.
* The game must include visible UI feedback such as lives and level number.
* The prototype must include game over and level complete feedback.
* The software must be documented, tested and linked to the original user stories and backlog.

### 5.2 Optional / Future Feature Requirements

Some features were considered useful but were not treated as essential for the final Sprint 2 prototype. These remain future development ideas:

* Additional levels beyond the current prototype level.
* Checkpoints for longer levels.
* Collectibles and score tracking.
* Shop or unlockable cosmetic items.
* More advanced enemy behaviour.
* Sound effects and music polish.
* Main menu and pause menu improvements.
* More detailed animations and visual effects.

These features were kept lower priority because the assignment required a working and testable prototype. The main focus was therefore placed on correctness, stability, maintainability and demonstrating the core platformer mechanics.

### 5.3 Final Acceptance Criteria

The project is considered successful if:

* The player can move left and right correctly.
* The player can jump and land on platforms reliably.
* The player cannot fall through the main terrain during normal gameplay.
* Spike hazards trigger the intended damage or respawn behaviour.
* Slime enemies act as obstacles and interact with the player through collision or trigger detection.
* The player can reach the goal flag and activate the level complete state.
* Lives and level number are visible to the player.
* Game over or retry behaviour is triggered when the player fails.
* The project is documented through the README, backlog, testing log and development review evidence.

---

## 6.0 User and System Requirements

### 6.1 User Requirements
- The game should be easy to understand and navigate
- The controls should be responsive and consistent
- Hazards and enemies should be clearly visible
- The player should receive clear feedback when they fail or finish a level
- Levels should become more challenging over time
- The game should be enjoyable and replayable

### 6.2 System Requirements
- The system shall allow the player to move left and right
- The system shall allow the player to jump using keyboard input
- The system shall detect collisions between the player and platforms
- The system shall detect collisions between the player and hazards
- The system shall detect collisions between the player and enemy monsters
- The system shall allow the player to collect items
- The system shall track level progress and lives
- The system shall display menus and gameplay UI
- The system shall support win and lose states
- The system shall run on a desktop PC using keyboard controls

### 6.3 Non-Functional Requirements
- The game should load quickly
- The controls should respond without noticeable delay
- The game should remain readable and visually clear
- The code should be modular and maintainable
- Scripts should be reusable where possible
- The game should be easy to test and debug

---

## 7.0 Scrum-Style User Stories:

The Scrum-Style User Stories were made more clearer and detailed including an acceptance criteria.

| User Story ID | Priority | User Story                                                                                         | Purpose / Justification                                               | Acceptance Criteria                                                                            |
| ------------- | -------- | -------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| US1           | High     | As a player, I want to move left and right so that I can navigate through the level.               | Core mechanic required for all gameplay and level traversal.          | The player moves left and right using keyboard input without freezing or drifting incorrectly. |
| US2           | High     | As a player, I want to jump smoothly so that I can cross gaps and reach platforms.                 | Jumping is essential for a platform game.                             | The player jumps only when grounded and lands correctly on platforms.                          |
| US3           | High     | As a player, I want hazards to damage or reset me so that the game has challenge and consequences. | Hazards create risk and give the game a fail condition.               | Touching spikes causes the player to lose a life or respawn.                                   |
| US4           | High     | As a player, I want slime enemies to act as obstacles so that the level feels more dangerous.      | Enemies make the level more dynamic than static hazards alone.        | Contact with a slime triggers the same damage/fail logic as hazards.                           |
| US5           | High     | As a player, I want to reach an end goal so that I can complete the level.                         | The player needs a clear objective.                                   | Reaching the goal flag displays the level complete state.                                      |
| US6           | Medium   | As a player, I want lives so that mistakes have consequences without ending the game immediately.  | Lives improve feedback and support replay attempts.                   | The lives UI decreases correctly after damage or death.                                        |
| US7           | Medium   | As a player, I want a level indicator so that I know my current progress.                          | The UI helps the player understand the game state.                    | The level number is visible and understandable during gameplay.                                |
| US8           | Medium   | As a player, I want retry/game over feedback so that I understand when I have failed.              | Clear fail feedback improves usability.                               | Game over or retry UI appears after the fail condition is reached.                             |
| US9           | Medium   | As a player, I want clear hazards, enemies and platforms so that the challenge feels fair.         | Good visual readability prevents unfair difficulty.                   | Hazards and enemies are visible and placed in reasonable positions.                            |
| US10          | Low      | As a player, I want collectibles so that exploration feels more rewarding.                         | Collectibles increase replayability but are not required for the MVP. | Collectibles can be picked up and tracked if implemented.                                      |
| US11          | Low      | As a player, I want multiple levels so that the game has more progression.                         | More levels increase content but add scope.                           | Completing one level loads another level if implemented.                                       |
| US12          | Low      | As a player, I want checkpoints so that longer levels feel fairer.                                 | Checkpoints reduce frustration in harder levels.                      | The player respawns at the latest checkpoint if implemented.                                   |
| US13          | Low      | As a player, I want advanced enemy behaviour so that later levels feel more varied.                | Advanced enemy AI improves challenge but is not essential.            | Enemies patrol or react more dynamically if implemented.                                       |
| US14          | Low      | As a player, I want a shop or unlockable items so that the game has extra depth.                   | This is a stretch goal for replayability.                             | The player can unlock or access items if implemented.                                          |
| US15          | Low      | As a player, I want sound and visual feedback so that actions feel more satisfying.                | Feedback improves game feel and polish.                               | Sound or visual effects play for important events if implemented.                              |
| US16          | Medium   | As a player, I want to dash so that I can move quickly across gaps and avoid hazards.              | Dash increases movement variety and gives the player more control.    | Pressing the dash input moves the player quickly in the chosen direction for a short time.     |
| US17          | Medium   | As a player, I want to double jump so that I can recover from mistakes and reach higher platforms. | Double jump improves mobility and allows more unique level design.    | The player can jump once in the air after the first jump, but cannot jump infinitely.          |

---

## 8.0 Scrum Product Backlog:

The product backlog was updated for Sprint 2 to add user story link, development tasks, testing and Story points. Story points were estimated using a simple scale where 1 is small, 3 is moderate, 5 is complex and 8 is high effort.

| Backlog ID | User Story Link | Feature / Development Task                  | Priority | StoryPoints  | Sprint         | Status           | Definition of Done                                             | Acceptance Test                                                  |
| ---------- | --------------- | ------------------------------------------- | -------- | :-------:    | -------------- | ---------------- | -------------------------------------------------------------- | ---------------------------------------------------------------- |
| B1         | US1             | Implement player left/right movement        | High     |     3        | Sprint1        | Complete         | Player moves smoothly using keyboard input.                    | Press A/D or arrow keys and confirm movement in both directions. |
| B2         | US2             | Implement jump mechanic and grounded check  | High     |     5        | Sprint1        | Complete         | Player jumps only while grounded and lands correctly.          | Press Space while grounded and confirm controlled jump/landing.  |
| B3         | US1, US2        | Configure Rigidbody2D and player collider   | High     |     3        | Sprint1        | Complete         | Player physics behave consistently.                            | Test movement, falling and platform landing.                     |
| B4         | US9             | Build tilemap/platform level layout         | High     |     5        | Sprint1        | Complete         | Level contains playable ground, platforms and gaps.            | Play through the level and confirm traversal is possible.        |
| B5         | US3             | Add spike hazard objects                    | High     |     3        | Sprint2        | Complete         | Spikes are visible and placed as dangerous obstacles.          | Move player into spikes and confirm damage/respawn logic.        |
| B6         | US3             | Implement Hazard.cs collision/trigger logic | High     |     5        | Sprint2        | Complete         | Hazard script calls the player damage method.                  | Touch spikes and confirm player takes a hit.                     |
| B7         | US4             | Add slime enemy object                      | High     |     3        | Sprint2        | Complete         | Slime appears in the level and acts as a threat.               | Run the game and confirm slime is visible in the Game view.      |
| B8         | US4, US13       | Implement EnemyPatrol.cs                    | Medium   |     5        | Sprint2        | Complete         | Slime patrols between set points or acts as a simple obstacle. | Observe enemy movement and test player contact.                  |
| B9         | US5             | Add goal flag trigger                       | High     |     3        | Sprint2        | Complete         | Goal flag triggers level complete state.                       | Reach the goal and confirm level complete panel appears.         |
| B10        | US6             | Implement lives system                      | Medium   |     5        | Sprint2        | Complete         | Player loses lives when damaged.                               | Take repeated hits and confirm lives reduce.                     |
| B11        | US7             | Add level number UI                         | Medium   |     3        | Sprint2        | Complete         | UI displays the current level.                                 | Run game and confirm level text is visible.                      |
| B12        | US6, US8        | Add game over logic                         | Medium   |     5        | Sprint2        | Complete         | Game over appears when lives run out.                          | Lose all lives and confirm game over panel appears.              |
| B13        | US8             | Add retry/restart support                   | Medium   |     3        | Sprint2        | Complete         | Player can restart after failure.                              | Trigger failure and confirm restart button or respawn works.     |
| B14        | US5             | Add level complete panel                    | Medium   |     3        | Sprint2        | Complete         | Level complete UI appears when the goal is reached.            | Reach goal flag and confirm panel appears.                       |
| B15        | US15            | Add basic code comments                     | Medium   |     2        | Sprint2        | Complete         | Main scripts include helpful comments.                         | Review scripts and confirm comments explain key logic.           |
| B16        | US10            | Add collectibles                            | Low      |     5        | Future         | Not completed    | Collectibles are picked up and counted.                        | Future test: touch collectible and confirm pickup.               |
| B17        | US11            | Add multiple levels                         | Low      |     8        | Future         | Not completed    | Completing a level loads the next one.                         | Future test: complete Level 1 and load Level 2.                  |
| B18        | US12            | Add checkpoints                             | Low      |     5        | Future         | Not completed    | Player respawns at latest checkpoint.                          | Future test: activate checkpoint, fail and respawn there.        |
| B19        | US14            | Add shop/unlock system                      | Low      |     8        | Future         | Not completed    | Player can unlock items.                                       | Future test: collect currency and unlock an item.                |
| B20        | US15            | Add sound effects                           | Low      |     3        | Future         | Not completed    | Sounds play for jump, damage and completion.                   | Future test: trigger each action and confirm audio.              |
| B21        | US16            | Dash mechanic                               | Medium   |     5        | Sprint2        | Completed        | Player can dash for a short burst                              | Player can dash in the air                                       |
| B22        | US17            | Double jump mechanic                        | Medium   |     5        | sprint2        | Completed        | Player can perform one extra jump in the air                   | Player can perform one extra jump in the air                     |

### 8.1 Backlog Evaluation

The backlog shows that the highest-priority features were completed first because they form the core playable platformer prototype. Player movement, jumping, platform collision, hazards, enemies, lives and level completion were prioritised because they directly affect whether the game can be played and tested. Lower-priority features such as collectibles, checkpoints, multiple levels and shop systems were moved into future development because they would increase scope without being essential to the core gameplay loop. This change demonstrates improved scope control from Sprint 1 to Sprint 2. Instead of trying to complete every possible feature, the final prototype focuses on delivering a stable version of the game that meets the main user and system requirements.

---

## 9.0 Overall Design and Development Strategy

The overall design strategy for LedgeBound is to create a platform game focused prototype that is stable, visually clear to navigate and easy to test. The project has been designed around the principle of starting with **building a stable core game**, then adding low and medium priority scrum features, this development strategy improves project management and allows the implemented game to be compared clearly with the original design specification.

The game follows an Agile-inspired strategy where high-priority mechanics are implemented first, tested, reviewed and refined before lower-priority ideas are explored. This is a crucial stratergy as it helps keep the project realistic to develop for an individual, while still supporting ambitious ideas in a controlled way increasing the project scope.

### 9.1 Design Priorities
1. **Stability** - build stable movement and jumping systems
2. **Functionality** - ensure collisions, hazards and fail states work correctly
3. **Progression** - add enemy monsters and level progression
4. **Feedback** - add clear UI feedback such as lives and level number
5. **Scalibility** - add optional features such as collectibles, multiple levels, checkpoints and shops if time allows

### 9.2 Development Order
Split into the following ten stages:
- **Stage 1:** Define project idea and scope
- **Stage 2:** Produce requirements and user stories
- **Stage 3:** Create scrum backlog
- **Stage 4:** Set up Unity project and scene structure
- **Stage 5:** Implement movement and jumping
- **Stage 6:** Add platforms, hazards and collisions
- **Stage 7:** Add enemies and end-goal system
- **Stage 8:** Add UI and feedback systems
- **Stage 9:** Add optional features and polish prototype
- **Stage 10:** Test, debug and refine

### 9.3 Sprint 2 Design and Development Updates

Sprint 2 focused on converting the early design into a more complete playable prototype. The main changes were:
* Hazard functionality was added using spike objects and a reusable hazard script.
* Slime enemies were added to act as dynamic obstacles.
* A goal flag trigger was added to create a clear level complete condition.
* Lives and level UI were added so the player receives feedback during gameplay.
* Game over and level complete panels were added to make win and lose states clearer.
* Testing was expanded so that implemented features could be compared against user stories and acceptance criteria.
* Optional features were reviewed and moved into future development where they were not essential for the final prototype.

The design strategy remained Agile-inspired. The project was developed through small improvements, with each major mechanic being implemented, tested, reviewed and refined before moving on to lower-priority features.

### 9.4 Problems Encountered and Solutions

| Problem / Barrier                                    | Cause                                                                          | Solution / Response                                                                        | Impact on Project                                                      |
| ---------------------------------------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------- |
| Ground check area was too wide                       | The ground check object did not match the player width correctly.              | The ground check was resized and repositioned in the Unity scene.                          | Improved jump reliability and reduced false grounded detection.        |
| Hazard spikes needed to function correctly           | Spikes existed visually but required collision/trigger behaviour.              | Hazard.cs was attached and configured to call the player damage method.                    | Spike hazards became functional gameplay obstacles.                    |
| Slime enemy visibility/functionality needed checking | Enemy object position, sprite settings or camera view could stop it appearing. | The slime object, patrol points, transform position and Game view visibility were checked. | Helped turn the slime from a planned feature into a testable obstacle. |
| Camera follow stopped at part of the level           | Camera movement can be limited by follow settings or scene boundaries.         | Camera behaviour was reviewed so the player remained visible during gameplay.              | Improved playability and demonstration quality.                        |
| Scope became too large                               | Features like shops, checkpoints and collectibles added complexity.            | Optional ideas were moved to future development.                                           | Kept the final prototype realistic and focused on core marks.          |

---

## 10.0 Project Scope and Minimum Viable Product (MVP)
The MVP for LedgeBound is a 2D playable platform game that includes:

- Player movement
- Jumping
- Platforms
- Hazard (Spikes)
- Slime enemies
- At least one complete level
- A visible level end-goal (finish flag)
- Win and lose conditions
- Lives and level number on the UI

This MVP defines the minimum version of the game required to satisfy the core gameplay objectives. Features such as collectibles, multiple levels, checkpoints, shops, stars/items and more advanced enemy behaviour are treated as extensions beyond the core build. This ensures that the project has a realistic scope and is prioritised carefully.

---

## 11.0 Game Story
LedgeBound uses a simple story allowing the prototype to be more gameplay driven. The player controls a lone adventurer travelling through a dangerous side-scrolling world filled with challenges such as spikes and slimes. The objective is to overcome the dangers of each stage and reach the end goal safely. The game ends when the player returns back to their cabin at the end of level 3 (the final level) providing a clear narrative conclusion. The story is intentionally lightweight so that the main focus remains on platforming mechanics and player progression.

---

## 12.0 Characters
### 12.1 Main Player Character (Dexter)
**Dexter** is the main controllable avatar/sprite. The character is designed to be visually clear and responsive so that movement and jumping feels precise and accurate. The character is able to:
- run left and right
- jump
- fall
- interact with platforms
- collide with hazards and enemies
- collect items
- complete levels

Dexter's Background:

A young male adventurer looking to return home, he wears a red cape and has brown/ginger hair with a quiff style. Dexter has an outgoing and positive personality allowing him to conquer any challenges he is faced with without giving up.
|Dexter Sprite|
|-----|
| ![60c4e0f2-102e-483f-974c-254e6c823fc1](https://github.com/user-attachments/assets/3f63a3e3-d62e-48b1-be05-7cf4f61669d1) |

---

### 12.2 Enemy Characters (Slime)
The main enemy type currently planned is the **slime monster sprite**. These enemies act as obstacles and add difficulty to the platforming experience. Their main design purpose is to:
- create more dynamic threats than static hazards alone
- force the player to time jumps carefully
- make later levels feel more dangerous

Slimes Background:

The slimes formed by space matter ascended on the world with only one goal which is to stick to any target and consume them, this allows the slimes to grow exponentially. The slime have a genderless, bubbly nature as they slide across the terrain.
|Slime Sprite|
|-----|
| <img width="325" height="325" alt="image" src="https://github.com/user-attachments/assets/2140ee5e-e38a-49ae-b44a-8eac459d5131" /> |

---

## 13.0 Artwork and Visual Design
LedgeBound uses a **2D pixel-art inspired style** with vibrant colours, clear contrasts and intense backgrounds. This style fits well with the game’s nostalgic inspiration and the target audience’s familiarity with older platform games. The visual design updates old 2D pixel styles with updated HD textures to give a clean fresher look.

### 13.1 Visual Goals
The visual design aims to:
- make the player character easy to follow
- make hazards and enemies easy to identify
- support a retro-inspired atmosphere
- keep gameplay readable at all times

### 13.2 Background Design
The backgrounds are intended to make each level feel more visually appealing and distinct without distracting from gameplay. Backgrounds are treated as part of the game’s presentation rather than as a gameplay mechanic. This means day/night variations or additional level themes are used to create level atmosphere and visual identity,
### 13.3 Visual Justification
A clear and readable visual style is important in a platform game because poor visibility can make difficulty feel unfair. For this reason, the backgrounds are designed to support the level rather than overwhelm it.

---

## 14.0 Sound Design
Sound is used to improve player feedback and make the game feel more responsive.

### 14.1 Game Sounds
- jump sound
- running/sprint sound
- damage/death sound
- collectible pickup sound
- enemy interaction sound
- level completion sound
- menu selection sound

### 14.2 Why I Included Sounds
Sound improves the game by:
- confirming actions immediately
- making movement and interactions feel more satisfying
- reinforcing success and failure states
- increasing the level of polish in the prototype

---

## 15.0 Environment and Level Design
The game uses a 2D side-scrolling platform environment built from platforms, gaps, hazards, enemies, collectibles and end-goal areas.

### 15.1 Environment Features
Each level may contain:
- safe ground and raised platforms
- gaps that require accurate jumping
- spike hazards or traps
- slime enemies
- optional collectibles
- a goal trigger at the end of the level

### 15.2 Level Design Principles
The level design is based on the following principles:
- introduce mechanics gradually
- increase challenge over time
- avoid unfair obstacle placement
- introduce hazards that require timing and careful movement
- scatter items based on new exploration

### 15.3 Final Level Structure

The final prototype focuses mainly on one complete playable level. This was chosen so that the core mechanics could be tested properly rather than spreading development time across several unfinished levels.
The final level follows this structure:

1. **Start area** – the player begins at a safe spawn point and can test movement and jumping.
2. **Platforming area** – the player moves across ground and platforms to demonstrate traversal.
3. **Hazard area** – spike hazards are introduced to test risk, damage and respawn behaviour.
4. **Enemy area** – slime enemies are placed as active obstacles to increase challenge.
5. **End goal area** – the player reaches the goal flag to trigger level completion.

This structure creates a simple but complete platformer loop: start, move, jump, avoid danger, survive and reach the goal. Future versions could expand this into three levels, where Level 1 introduces the mechanics, Level 2 increases hazard and enemy difficulty, and Level 3 combines all mechanics into a final challenge.

---

## 16.0 Gameplay and Core Mechanics

### 16.1 Implemented Core Mechanics

The final Sprint 2 prototype includes the following core mechanics:
- Horizontal player movement.
- Jumping using a grounded check.
- Gravity and Rigidbody2D physics.
- Platform and terrain collision.
- Spike hazard interaction.
- Slime enemy interaction.
- Lives tracking.
- Level number display.
- Goal flag / level complete trigger.
- Game over and retry behaviour.
- Dash movement ability.
- Double jump ability.

### 16.2 Core Gameplay Loop

The gameplay loop is:
1. The player starts at the spawn point.
2. The player moves through the level using keyboard controls.
3. The player jumps across platforms and gaps.
4. The player avoids spikes and slime enemies.
5. If the player touches a hazard, enemy or falls below the level, they lose a life or respawn.
6. If lives remain, the player can continue or retry.
7. If no lives remain, the game over state is shown.
8. If the player reaches the goal flag, the level complete state is shown.

### 16.3 Why These Mechanics Were Prioritised

These mechanics were prioritised because they represent the essential requirements of a 2D platformer. Movement and jumping make the game playable, collisions make the level stable, hazards and enemies create challenge, and goal/game over states make success and failure clear. This also makes the project easier to test because each feature can be linked directly to a user story, backlog item and acceptance test.

---

## 17.0 Player Motivation Loop
The game is built using a simple but effective motivation loop. The motivation loop is based on challenge, retry and progression.
### 17.1 Player State
The player begins with the goal of reaching the end of the level safely.
### 17.2 Need
The player needs to navigate platforms safely while avoiding hazards and enemies, with responsive controls.
### 17.3 Challenge
The challenge comes from:
- platform spacing
- jump timing
- hazards
- enemies
- increasing difficulty across levels
- lives system

### 17.4 Reward
The reward comes from:
- successful level completion
- surviving difficult sections
- reaching the goal flag and activating the level complete state.
- improving personal performance through repeated attempts

### 17.5 Evaluation of Motivation Loop
The motivation loop is simple but suitable for the prototype. It gives the player a clear aim, understandable risks and immediate feedback after success or failure. In future development, the loop could be improved with collectibles, score tracking, sound effects and multiple levels to increase replay value.

---

## 18.0 Game Rules

The final game rules are:
* The player begins at a defined spawn point.
* The player uses keyboard controls to move and jump.
* The player must avoid spike hazards and slime enemies.
* Touching a hazard or enemy causes the player to take damage or respawn.
* Falling below the level triggers the fail/death behaviour.
* The player has a limited number of lives.
* If lives remain, the player can retry or continue from the spawn point.
* If all lives are lost, the game over state is shown.
* Reaching the goal flag completes the level.
* Optional systems such as collectibles, checkpoints and shops are future development features.

These rules keep the prototype clear and testable. The player always knows what they must do, what counts as failure and how to complete the level.

---

## 19.0 State Management

|**Game State Diagram:** The diagram shows the main gameplay states and transitions in LedgeBound.|
|-----|
| <img width="1278" height="1273" alt="StateSD2Diagram drawio" src="https://github.com/user-attachments/assets/450b096e-376b-4b92-ab48-ec87f13624a3" /> |

| Current State | Condition | Next State | Description |
|---|---|---|---|
| Game Load | The game is launched | Main Menu | The game begins by loading into the main menu. |
| Main Menu | The player selects play | Playing | Selecting play starts the gameplay state. |
| Playing | The player presses the pause button | Paused | Pausing temporarily stops gameplay. |
| Paused | The player resumes the game | Playing | Resuming returns the player to gameplay. |
| Playing | The player touches a hazard | Player Dead | Contact with a hazard causes a death state. |
| Playing | The player touches an enemy | Player Dead | Contact with an enemy causes a death state. |
| Playing | The player falls off the level | Player Dead | Falling off the stage causes a death state. |
| Player Dead | Lives remain | Retry | If the player still has lives left, they can retry or continue playing state with a life lost. |
| Retry | The level restarts | Playing | Retrying returns the player to the beginning of the level gameplay. |
| Player Dead | No lives remain | Game Over | If no lives remain, the game ends in a game over state. |
| Game Over | No lives remain | Main Menu | When no lives remain a failure message is shown allowing the user to return to the main menu state or retry state. |
| Playing | The player reaches the end goal | Level Complete | Reaching the goal completes the current level. |
| Level1 Complete | More levels remain | Playing | If more levels remain and user has reached the finish, the next level begins. |
| Level2 Complete | More levels remain | Playing | If more levels remain and user has reached the finish, the next level begins. |
| Level3 Complete | Final level completed | Final Win | Completing the last level shows the final win state. |
| Final Win | Level3 completed | Main Menu | If level3 completed, the game ends with a congratulation message returning the user to the main menu state. |

## 20.0 Why State Management Matters
State management is important because it helps organise the gameplay flow, UI behaviour and scene changes. It also makes the project easier to test and reduces the risk of conflicting logic between menus, level progression and fail states.

---

## 21.0 Programming Language and Platform

### 21.1 Game Engine:
**Unity**

### 21.2 Programming Language:
**C#**

Chosen because it integrates directly with Unity and supports modular object-oriented scripting(code that defines how game objects behave and interact within the Unity game engine). This helps keep the code organised and maintainable.

### 21.3 Target Platform:
**Desktop PC**

Selected as the target platform because it allows easier testing during development, supports keyboard controls, and provides a straightforward approach for demonstrating the game.

### 21.4 Input Method:
**Keyboard Controls**, **Mouse Click**

### 21.5 Justification:
Unity was chosen because it provides strong support for:
- 2D game development  
- built-in systems  
- scene management and creation
- sprite handling
- user interface (UI) systems

---

## 22.0 User Interface and Controls

### 22.1 Controls

| Action | Input |
|---|---|
| Move Left | A / Left Arrow |
| Move Right | D / Right Arrow |
| Jump | Space |
| Double Jump | Press Space again while airborne |
| Dash | Left Shift |
| Navigation | Left Mouse Click |

### 22.2 Implemented UI Elements

The final prototype includes simple UI elements that support gameplay feedback:
- Lives display.
- Level number display.
- Game over panel.
- Level complete panel.
- Retry or button-based navigation where required.

### 22.3 Planned / Future UI Elements

Future versions could include:
- Main menu improvements.
- Pause menu.
- Settings menu.
- Collectible counter.
- Sound toggle.
- Improved win screen.

### 22.4 UI Design Principles

The UI is designed to be simple, readable and low-clutter. This is important because the player should focus mainly on movement, hazards and enemies rather than complex menus. The UI supports the gameplay by showing the most important information: lives, level progress, failure and completion.

---

## 23.0 Technical and Programming Challenges

### 23.1 Physics and Jump Balancing
The jump system must feel responsive and fair. Poor balance between gravity, movement speed and jump force can make the game become frustrating.

### 23.2 Collision Handling
Reliable collisions are essential for:
- platforms
- hazards
- enemies
- collectibles
- goal triggers

Any collision issue can directly break the gameplay loop.

### 23.3 Level Balance
Levels must be challenging without becoming unfair, poor spacing or unclear hazards can make the game unlikeable.

### 23.4 State Coordination
Menus, retries, gameplay and end screens all need to transition correctly, this requires careful control of scenes and gameplay states.

### 23.5 Scope Management
The project contains several lower-priority extension ideas such as shops, stars/items and advanced enemy behaviour, these are useful for depth but they also create a risk of over-scoping if not prioritised carefully.

### 23.6 Enemy Behaviour
Enemy logic needs to be reliable and readable, enemies should create challenge without behaving unpredictably or unfairly.

### 23.7 Final Technical Challenge Evaluation
The main technical challenges were related to Unity physics, collision detection and scene setup. Platform games depend heavily on reliable collisions, so small configuration issues can affect the entire experience. For example, if the ground check is too large, the player may jump at the wrong time; if a hazard collider is not configured correctly, the spike may not damage the player; and if an enemy is outside the camera view, it may appear as if the feature is broken.

These issues were handled through repeated playtesting, inspector checks and script separation. Instead of placing all logic in one large file, the project uses separate scripts for player behaviour, hazards, enemy patrol, goal detection and game management. This improved maintainability because each script has a clear responsibility.

---

## 24.0 Basic Pseudocode

### 24.1 Player Movement
```text
IF left key is pressed
    move player left
ELSE IF right key is pressed
    move player right
END IF

IF jump key is pressed AND player is grounded
    apply jump motion
END IF
```
### 24.2 Hazard Collisions
```text
WHEN player touches hazard
    reduce lives
    IF lives > 0
        restart from spawn point
    ELSE
        load game over state
    END IF
END WHEN
```
### 24.3 Enemy Collisions
```text
WHEN player touches slime enemy
    apply damage or fail logic
    IF lives remain
        restart or continue from checkpoint
    ELSE
        load game over state
    END IF
END WHEN
```
### 24.4 Level Comlpetion
```text
WHEN player reaches end goal
    IF current level is not final level
        load next level
    ELSE
        load win state
    END IF
END WHEN
```

---

## 25.0 Project Management Approach

The project follows a scrum-inspired agile approach, this means:
- requirements are converted into scrum user stories
- scrum user stories are transformed into backlog items
- backlog items are prioritised by importance
- progress is reviewed regularly
- testing and refinement happen throughout the development

This approach supports realistic planning and helps keep the project focused on the most important gameplay features first.
I have created a seperate file for all the necesarry planning techniques: backlog reviews, development meetings and the burndown chart here: [BacklogReviews&Meetings.md](./BacklogReviews&Meetings.md).

---

## 26.0 Testing Strategy
Testing is carried out throughout development rather than only at the end. This allows for issues to be identified early and helps ensure that implemented features match the original design specification.

## 26.1 Testing Objectives
Testing is used to confirm that:
- The game meets the user requirements
- The game meets the system requirements
- Implemented features match backlog definitions
- The gameplay loop functions correctly
- Later additions do not break earlier features
- Every feature works as intended

## 26.2 Types of Testing
The project uses:
- Functional testing
- Collision testing
- Playtesting
- UI testing
- State transition testing

## 26.3 Testing Method
Each feature is tested after implementation. If a problem is found, it is logged, fixed and retested. High-priority functions such as movement, jumping, collisions and level completion are tested more frequently since they affect the playability of the whole game.
Detailed testing evidence such as the test plan and log is found in: [Testing.md](./Testing.md).

---

## 27.0 Evaluation
Evaluating whats has been done and what is in active development.

### 27.1 Evidence of Progress Against the Design Specification
The project demonstrates progress against the design specification through the following completed or clearly defined areas and implemented or in active development below:

### 27.2 Completed or Strongly Defined:
- Project concept and scope
- Target audience review
- User requirements and system requirements
- Scrum user stories
- Prioritised product backlog with definitions and tests
- Game story, characters and environment planning
- Gameplay mechanics and rules
- State management planning
- Platform and input decisions
- Software tools and coding techniques
- Backlog reviews
- Development review meetings
- Burndown tracking
- Testing strategy and test plan
- Research resources (Refrences)

### 27.3 Implemented or In Active Development:
- Unity project setup
- Player movement
- Jump behaviour
- Platform collision logic
- Hazard planning and testing
- Slime enemy planning and integration
- UI planning for lives and level number
- Level progression structure
- Optional collectible systems

This shows the systematically development of the project and that implementation is being measured against the original requirements, user stories, backlog and testing expectations. The acceptance criteria for the prototype is not completed as development is still in progress, the criteria should be met in the second stint.

## 28.0 Scripts Folder
The Scripts folder is responsible for the scripts i created in development,
it is found here: [Scripts](./Scripts)

---

## 29.0 Software Tools and Coding Techniques

### 29.1 Software Tools Used
| Tool | Purpose |
|---|---|
| Unity | Main development engine |
| Visual Studio / VS Code | Writing and debugging C# scripts |
| GitHub | Version control and documentation |
| Diagram / Flowchart tool: Draw.io | Planning logic and state flow |

### 29.2 Coding Techniques Used
The project uses:
- object-oriented programming
- modular script design
- reusable scripts where possible
- conditionals and loops
- trigger-based interactions
- scene management
- state-based logic
- debugging through Unity console output and repeated playtesting

### 29.3 Maintainability and Reusability
Scripts are designed to be reusable wherever possible. For example:
- one enemy controller can be used across multiple slime enemies
- one collectible script can manage many pickups
- one hazard script can be attached to multiple traps

This reduces duplicated code and improves maintainability.

---

## 30.0 References
Downloaded the following free Sprite Assets to use in unity:
<img width="1000" height="800" alt="image" src="https://github.com/user-attachments/assets/7e32ad99-7494-4991-8777-3e6dbb6d9ee6" />

Refrence Videos to help with developing the game:

https://www.youtube.com/watch?v=lIZnIFqai2I&list=PLXG1jSmcT-NXIHOPL8cZGXvDEGZ3gzurt&index=1
- Making a 2D Platformer In Unity 6 - Episode 1 (Full Course)
Channel: Unity Unlocked

---
