## Brief Introduction
This repository contains the game **LedgeBound** developed for the Software Development 2 module. The project is a 2D platformer game inspired by the hit classic Mario. 

---

<p align="center">
  <img width="300" src="https://i.postimg.cc/3Rm8qn4W/Ledge-Bound-13-03-2026.png">
</p>

<p align="center">
  <b>A 2D Platform Game</b>
</p>

---

## Reviewing Project Ideas

### 2D Side-Scrolling Platformer
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

### Endless Runner
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

### Puzzle Platformer
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

### Project Decision: 2D Side-Scrolling Platformer
After reviewing the possible project ideas, a 2D side-scrolling platformer was selected as it aligns well with Unity development and provided an opportunity to gain experience using the Unity game engine.
The platformer structure also makes it easier to divide the game into manageable sections such as player movement, hazards, collectibles, level progression, state management and user interface.
It allows the project to demonstrate the Scrum software development lifecycle through requirements analysis, design, backlog planning, implementation, testing and review.

I have created a powerpoint pitch for the game describing essential fundamentals here: [SD2_Platform_Game_Pitch.pptx](./SD2_Platform_Game_Pitch.pptx)

---

## Reviewing Target Audience

### Casual Gamers
Characteristics:
- Prefer simple controls
- Want enjoyable short play sessions
- Expect quick understanding of the game

### Nostalgic Platform Game Fans
Characteristics:
- Familiar with platform games
- Often enjoy nostalgic games inspired by older titles
- Prefer addictive but easy-to-play experiences

### Students/Young Adults Aged 18-25
Characteristics:
- Notice movement quality and jump accuracy
- Appreciate fair challenge and good level flow
- Enjoy replayable platforming mechanics

---

## Project Aim and Objectives

### Aim
To develop a functional 2D side-scrolling platform game in which the player runs, jumps, avoids hazards(including enemies), and reaches the end of each level.

### Objectives
- Identify user and system requirements
- Produce scrum-style user stories and a prioritised backlog
- Design the gameplay, levels, characters, environment and UI
- Use Unity and C# to implement the game
- Track development progress using backlog reviews
- Test the game against requirements, functions and features
- Produce a playable prototype suitable for demonstration

---

## Overall Specification – Ledge Bound

### Core Features Requirements
- The player must be able to run and jump smoothly
- The player must be able to move through side-scrolling levels
- The game must contain platforms, gaps and hazards
- The game must include enemy monster sprites (slimes)
- The game must include multiple levels
- The game must contain win and lose conditions
- The UI must display lives and level number
- The game should provide sound and visual feedback

### Optional Features Requirements
- Checkpoints
- Pause menu
- Additional level themes
- Improved enemy movement
- Animated effects
- Include collectible cosmetic items
- Add a score function
- Night and day backgrounds

### Acceptance Criteria
The project will be considered successful if:
- The player can move and jump accurately
- Platform and hazard collisions function correctly
- Enemy monster interactions work correctly
- At least one complete playable level is included
- Win and lose conditions function correctly
- The UI displays level and lives clearly

---

## User and System Requirements

### User Requirements
- The game should be easy to understand and navigate
- The controls should be responsive and consistent
- Hazards and enemies should be clearly visible
- The player should receive clear feedback when they fail or finish a level
- Levels should become more challenging over time
- The game should be enjoyable and replayable

### System Requirements
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

### Non-Functional Requirements
- The game should load quickly
- The controls should respond without noticeable delay
- The game should remain readable and visually clear
- The code should be modular and maintainable
- Scripts should be reusable where possible
- The game should be easy to test and debug

---

## Scrum-Style User Stories:

| User Story ID | Priority | User Story | Purpose / Justification |
|---|---|---|---|
| US.1 | High | As a player, I want to move left and right so that I can navigate through the level. | This is a core mechanic required for all gameplay and level traversal. |
| US.2 | High | As a player, I want to jump smoothly so that I can cross gaps and reach platforms. | Jumping is essential in a platform game and supports progression through the level. |
| US.3 | High | As a player, I want hazards to damage or reset me so that the game is more challenging. | Hazards introduce risk and create meaningful fail conditions. |
| US.4 | High | As a player, I want monsters to act as obstacles so that the level feels more dangerous. | Enemies make the gameplay more dynamic and challenging than static hazards alone. |
| US.5 | High | As a player, I want to reach an end goal so that I can finish the level. | A clear goal is needed so the player understands how to complete the stage. |
| US.6 | Medium | As a player, I want lives so that mistakes have consequences. | A lives system makes failure meaningful and supports the retry/game over structure. |
| US.7 | Medium | As a player, I want cosmetic collectibles so that exploration feels rewarding. | Collectibles encourage exploration and improve replayability. |
| US.8 | Medium | As a player, I want level indicators so that I can track my progress. | Level indicators provide useful feedback and help the player understand progression. |
| US.9 | Medium | As a player, I want sound and visual feedback so that actions feel satisfying. | Feedback improves responsiveness and makes interactions feel clearer and more polished. |
| US.10 | Medium | As a player, I want a visually appealing background for each level so that the world feels more dynamic. | Background design strengthens presentation and helps levels feel more distinct. |
| US.11 | Low | As a player, I want multiple levels so that the game has more replay value. | Multiple levels add progression and increase the amount of playable content. |
| US.12 | Low | As a player, I want checkpoints so that longer levels feel fairer. | Checkpoints reduce frustration and improve usability in harder or longer stages. |
| US.13 | Low | As a player, I want more advanced enemy behaviour so that later levels feel more difficult. | More advanced enemy logic can make later stages feel more varied and demanding. |
| US.14 | Low | As a player, I want a shop with items that can be unlocked so that the game is more fun. | A shop system is an optional extension that can increase depth and player motivation. |
| US.15 | Low | As a player, I want stars/items that can be collected on each level so that the game is more replayable. | Extra items create optional completion goals and encourage replay. |

---

## Scrum Product Backlog:

| Backlog ID | Feature / Function | Priority | Description | Definition of Done | Evaluation / Justification | Test |
|---|---|---|---|---|---|---|
| B.1 | Player Movement | High | Allow the player to move left and right using keyboard controls. | The player moves smoothly and coherently in both directions. | Essential for all gameplay and the most basic interaction in the project. | Press left/right keys and verify movement speed and direction. |
| B.2 | Jump Mechanic | High | Allow the player to jump while grounded. | The player jumps, reaches appropriate height and lands correctly. | A platform game is not playable without a reliable jumping system. | Press jump key and verify jump response and landing behaviour. |
| B.3 | Platform Collision | High | Ensure the player interacts correctly with platforms. | The player lands on platforms and does not fall through the environment/terrain. | Collision reliability is essential for fair gameplay. | Land on platforms from different positions and confirm stability. |
| B.4 | Hazard Detection | High | Hazards (spikes) should damage, reset or defeat the player. | Touching a hazard causes the correct fail or life-loss response. | Hazards create risk and support the challenge loop. | Touch spikes or traps and verify the correct response. |
| B.5 | Enemy Monsters | High | Introduce slime enemies as moving or placed obstacles. | Enemy contact affects the player correctly. | Enemies make the game more dynamic than hazards alone. | Trigger player-enemy collision and verify result. |
| B.6 | End Goal | High | Reaching the goal completes the level. | The level ends or the next level loads correctly. | Gives the player a clear objective and win state. | Reach goal trigger and verify level completion. |
| B.7 | Retry / Restart | High | The player should be able to retry after failing. | A failed level can be restarted correctly. | Supports replayability and the core gameplay loop. | Fail the level and verify restart logic. |
| B.8 | Lives System | Medium | Track the number of lives the player has left. | Lives decrease correctly when the player is damaged or defeated. | Supports feedback and gives consequences to mistakes. | Trigger multiple failures/deaths and verify life value updates. |
| B.9 | Level Indicator | Medium | Display the current level on screen. | The UI shows the correct level number. | Helps the player understand progression. | Load levels and verify displayed level number. |
| B.10 | Cosmetic Collectibles | Medium | Add optional collectible items to encourage exploration. | Collectibles disappear when picked up and are counted or acknowledged. | Increases reward and replay value. | Touch collectible and verify pickup behaviour. |
| B.11 | Sound Feedback | Medium | Add sound effects for important actions. | Audio plays for jumps, damage, pickups and level completion. | Improves responsiveness and game feel. | Trigger supported actions and verify sound plays. |
| B.12 | Background Design | Medium | Use visually appealing backgrounds for each level. | Each level has a readable and distinct background. | Supports presentation and strengthens visual identity. | Load levels and confirm background is visible and appropriate. |
| B.13 | Main Menu | Medium | Provide a starting menu for the game. | The game opens to a menu and can launch into gameplay. | Improves usability and presentation. | Start the project and verify menu navigation. |
| B.14 | Game Over Screen | Medium | Show a fail state if the player loses completely. | A game over screen appears when the fail condition is final. | Makes the fail state clear to the player. | Lose all lives and verify screen appears. |
| B.15 | Multiple Levels | Low | Include more than one playable level. | Level progression. | Adds progression and replayability, but the prototype can still function with one complete level. | Complete one level and verify the next level loads. |
| B.16 | Checkpoints | Low | Add checkpoints to longer or harder levels. | The player respawns from the latest checkpoint rather than the level start. | Improves fairness in longer levels. | Activate a checkpoint, fail, and verify respawn location. |
| B.17 | Advanced Enemy Behaviour | Low | Expand enemy logic beyond simple obstacle behaviour. | Enemies patrol or react more dynamically. | Useful extension, but not essential for the core prototype. | Observe enemy movement and verify behaviour matches design. |
| B.18 | Shop System | Low | Add unlockable or purchasable items. | The player can access a shop and unlock an item if implemented. | A target feature that adds depth and replayability but is not required for the core prototype. | Access shop menu and verify unlock logic. |
| B.19 | Stars / Extra Items | Low | Add optional stars or extra collectibles on each level. | Items can be collected and tracked correctly, able to use in the shop. | Supports replayability and optional completion goals. | Collect items and verify progress updates. |
| B.20 | Pause Menu | Low | Allow the player to pause and resume gameplay. | Gameplay pauses and resumes without breaking the state. | Helpful for usability, but secondary to the core mechanics. | Pause during gameplay and verify resume function works. |

---

## Overall Design and Development Strategy

The overall design strategy for LedgeBound is to create a platform game focused prototype that is stable, visually clear to navigate and easy to test. The project has been designed around the principle of starting with **building a stable core game**, then adding low and medium priority scrum features, this development strategy improves project management and allows the implemented game to be compared clearly with the original design specification.

The game follows an Agile-inspired strategy where high-priority mechanics are implemented first, tested, reviewed and refined before lower-priority ideas are explored. This is a crucial stratergy as it helps keep the project realistic to develop for an individual, while still supporting ambitious ideas in a controlled way increasing the project scope.

### Design Priorities
1. **Stability** - build stable movement and jumping systems
2. **Functionality** - ensure collisions, hazards and fail states work correctly
3. **Progression** - add enemy monsters and level progression
4. **Feedback** - add clear UI feedback such as lives and level number
5. **Scalibility** - add optional features such as collectibles, multiple levels, checkpoints and shops if time allows

### Development Order
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

---

## Project Scope and Minimum Viable Product (MVP)
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

## Game Story
LedgeBound uses a simple story allowing the prototype to be more gameplay driven. The player controls a lone adventurer travelling through a dangerous side-scrolling world filled with challenges such as spikes and slimes. The objective is to overcome the dangers of each stage and reach the end goal safely. The game ends when the player returns back to their cabin at the end of level 3 (the final level) providing a clear narrative conclusion. The story is intentionally lightweight so that the main focus remains on platforming mechanics and player progression.

---

## Characters
### Main Player Character (Dexter)
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

### Enemy Characters (Slime)
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

## Artwork and Visual Design
LedgeBound uses a **2D pixel-art inspired style** with vibrant colours, clear contrasts and intense backgrounds. This style fits well with the game’s nostalgic inspiration and the target audience’s familiarity with older platform games. The visual design updates old 2D pixel styles with updated HD textures to give a clean fresher look.

### Visual Goals
The visual design aims to:
- make the player character easy to follow
- make hazards and enemies easy to identify
- support a retro-inspired atmosphere
- keep gameplay readable at all times

### Background Design
The backgrounds are intended to make each level feel more visually appealing and distinct without distracting from gameplay. Backgrounds are treated as part of the game’s presentation rather than as a gameplay mechanic. This means day/night variations or additional level themes are used to create level atmosphere and visual identity,
### Visual Justification
A clear and readable visual style is important in a platform game because poor visibility can make difficulty feel unfair. For this reason, the backgrounds are designed to support the level rather than overwhelm it.

---

## Sound Design
Sound is used to improve player feedback and make the game feel more responsive.

### Game Sounds
- jump sound
- running/sprint sound
- damage/death sound
- collectible pickup sound
- enemy interaction sound
- level completion sound
- menu selection sound

### Why I Included Sounds
Sound improves the game by:
- confirming actions immediately
- making movement and interactions feel more satisfying
- reinforcing success and failure states
- increasing the level of polish in the prototype

---

## Environment and Level Design
The game uses a 2D side-scrolling platform environment built from platforms, gaps, hazards, enemies, collectibles and end-goal areas.

### Environment Features
Each level may contain:
- safe ground and raised platforms
- gaps that require accurate jumping
- spike hazards or traps
- slime enemies
- optional collectibles
- a goal trigger at the end of the level

### Level Design Principles
The level design is based on the following principles:
- introduce mechanics gradually
- increase challenge over time
- avoid unfair obstacle placement
- introduce hazards that require timing and careful movement
- scatter items based on new exploration

### Planned Level Structure
**Level 1**
- introduces movement and jumping
- uses simple platforms
- introduces basic hazards safely

**Level 2**
- increases difficulty through tighter jumps and enemy placement
- begins to reward exploration through optional item placement

**Level 3**
- combines earlier mechanics into a more demanding level
- acts as a stronger test of movement, awareness and timing

This progressive structure makes the game easier to learn while still supporting replayability and challenge. 
Level 1 can be thought to act as a mini tutorial before the other two levels begin.

---

## Gameplay and Core Mechanics
### Core Mechanics
The main mechanics of the game are:
- Horizontal movement
- Jumping
- Gravity and ground checks
- Platform collision
- Hazard detection
- Enemy interaction
- Item collection
- Lives tracking
- Level progression
- Win and lose states

### Core Gameplay Loop
1. Start the level  
2. Move through the environment  
3. Jump between platforms  
4. Avoid spike hazards and slime enemies  
5. Collect optional items  
6. Retry after failure/death if lives exist  
7. Reach the end goal  
8. Progress to the next level or complete the game  

### Why These Mechanics Were Chosen
These mechanics were chosen because they are:
- essential to the platform genre
- achievable within the available timescale
- strongly aligned with Unity’s strengths
- highly testable and easy to compare with requirements and backlog items

---

## Player Motivation Loop
The game is built using a simple but effective motivation loop.
### Player State
The player wants to survive and complete each level.
### Need
The player needs to navigate platforms safely while avoiding hazards and enemies.
### Challenge
The challenge comes from:
- platform spacing
- jump timing
- hazards
- enemies
- increasing difficulty across levels

### Reward
The reward comes from:
- successful level completion
- surviving difficult sections
- collecting optional items
- reaching later stages
- improving personal performance through repeated attempts
This loop supports replayability and encourages the player to keep trying even after failure.

---

## Game Rules

The rules of LedgeBound are:
- The player begins each level at a start point
- The player must use movement and jumping to navigate the stage
- Touching hazards or enemies causes damage resulting in failure or life loss
- Falling off the level causes failure
- Reaching the end goal completes the level
- Lives limit how many mistakes the player can make before a game over condition occurs.
- Collectibles are optional but reward exploration
- The final level ends in victory if completed
These rules ensure the player always understands both their objective and the consequences of their actions.

---

## State Management

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

## Why State Management Matters
State management is important because it helps organise the gameplay flow, UI behaviour and scene changes. It also makes the project easier to test and reduces the risk of conflicting logic between menus, level progression and fail states.

---

## Programming Language and Platform

### Game Engine:
**Unity**

### Programming Language:
**C#**

Chosen because it integrates directly with Unity and supports modular object-oriented scripting(code that defines how game objects behave and interact within the Unity game engine). This helps keep the code organised and maintainable.

### Target Platform:
**Desktop PC**

Selected as the target platform because it allows easier testing during development, supports keyboard controls, and provides a straightforward approach for demonstrating the game.

### Input Method:
**Keyboard Controls**, **Mouse Click**

### Justification:
Unity was chosen because it provides strong support for:
- 2D game development  
- built-in systems  
- scene management and creation
- sprite handling
- user interface (UI) systems

---

## User Interface and Controls

### Controls

| Action | Input |
|------|------|
| Move Left | A / Left Arrow |
| Move Right | D / Right Arrow |
| Jump | Space / Up Arrow |
| Pause | P / Esc |
| Navigation | Left Mouse Click |

## Planned UI Elements
The planned UI elements for **LedgeBound** are:

- Main menu
- Start/Play button
- Level indicator
- Lives display
- Items display indicator
- Game over screen
- Death screen
- Win screen
- Pause menu

## UI Design Principles
The interface is designed to be:

- Simple
- Readable
- Consistent
- Supports the gameplay
- Easy to understand

The UI should communicate the player’s progress and the current game state clearly, while avoiding unnecessary clutter.

---

## Technical and Programming Challenges

### Physics and Jump Balancing
The jump system must feel responsive and fair. Poor balance between gravity, movement speed and jump force can make the game become frustrating.

### Collision Handling
Reliable collisions are essential for:
- platforms
- hazards
- enemies
- collectibles
- goal triggers

Any collision issue can directly break the gameplay loop.

### Level Balance
Levels must be challenging without becoming unfair, poor spacing or unclear hazards can make the game unlikeable.

### State Coordination
Menus, retries, gameplay and end screens all need to transition correctly, this requires careful control of scenes and gameplay states.

### Scope Management
The project contains several lower-priority extension ideas such as shops, stars/items and advanced enemy behaviour, these are useful for depth but they also create a risk of over-scoping if not prioritised carefully.

### Enemy Behaviour
Enemy logic needs to be reliable and readable, enemies should create challenge without behaving unpredictably or unfairly.

---

## Basic Pseudocode

### Player Movement
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
### Hazard Collisions
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
### Enemy Collisions
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
### Level Comlpetion
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

## Project Management Approach

The project follows a scrum-inspired agile approach, this means:
- requirements are converted into scrum user stories
- scrum user stories are transformed into backlog items
- backlog items are prioritised by importance
- progress is reviewed regularly
- testing and refinement happen throughout the development

This approach supports realistic planning and helps keep the project focused on the most important gameplay features first.
I have created a seperate file for all the necesarry planning techniques: backlog reviews, development meetings and the burndown chart here: [BacklogReviews&Meetings.md](./BacklogReviews&Meetings.md).

---

## Testing Strategy
Testing is carried out throughout development rather than only at the end. This allows for issues to be identified early and helps ensure that implemented features match the original design specification.

## Testing Objectives
Testing is used to confirm that:
- The game meets the user requirements
- The game meets the system requirements
- Implemented features match backlog definitions
- The gameplay loop functions correctly
- Later additions do not break earlier features
- Every feature works as intended

## Types of Testing
The project uses:
- Functional testing
- Collision testing
- Playtesting
- UI testing
- State transition testing

## Testing Method
Each feature is tested after implementation. If a problem is found, it is logged, fixed and retested. High-priority functions such as movement, jumping, collisions and level completion are tested more frequently since they affect the playability of the whole game.
Detailed testing evidence such as the test plan and log is found in: [Testing.md](./Testing.md).

---

## Evaluation
Evaluating whats has been done and what is in active development.

### Evidence of Progress Against the Design Specification
The project demonstrates progress against the design specification through the following completed or clearly defined areas and implemented or in active development below:

### Completed or Strongly Defined:
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

### Implemented or In Active Development:
- Unity project setup
- Player movement
- Jump behaviour
- Platform collision logic
- Hazard planning and testing
- Slime enemy planning and integration
- UI planning for lives and level number
- Level progression structure
- Optional collectible systems

This shows the systematically development of the project and that implementation is being measured against the original requirements, user stories, backlog and testing expectations.

## Script Devlopment
The Scripts folder is responsible for the scripts i created in development,
it is found here: [Scripts](./Scripts)

---

## Software Tools and Coding Techniques

### Software Tools Used
| Tool | Purpose |
|---|---|
| Unity | Main development engine |
| Visual Studio / VS Code | Writing and debugging C# scripts |
| GitHub | Version control and documentation |
| Diagram / Flowchart tool: Draw.io | Planning logic and state flow |

### Coding Techniques Used
The project uses:
- object-oriented programming
- modular script design
- reusable scripts where possible
- conditionals and loops
- trigger-based interactions
- scene management
- state-based logic
- debugging through Unity console output and repeated playtesting

### Maintainability and Reusability
Scripts are designed to be reusable wherever possible. For example:
- one enemy controller can be used across multiple slime enemies
- one collectible script can manage many pickups
- one hazard script can be attached to multiple traps

This reduces duplicated code and improves maintainability.

---

## References
Downloaded the following free Sprite Assets to use in unity:
<img width="1000" height="800" alt="image" src="https://github.com/user-attachments/assets/7e32ad99-7494-4991-8777-3e6dbb6d9ee6" />

Refrence Videos to help with developing the game:

https://www.youtube.com/watch?v=lIZnIFqai2I&list=PLXG1jSmcT-NXIHOPL8cZGXvDEGZ3gzurt&index=1
- Making a 2D Platformer In Unity 6 - Episode 1 (Full Course)
Channel: Unity Unlocked

---
