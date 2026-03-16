## Brief Introduction
A repository for the game i created for the Software Development 2 Module, it is a 2D game inspired by the infamous 2D platformer ‘Mario’. 

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
A game where the player moves from left to right through levels, jumping across platforms, avoiding hazards and reaching a end goal.

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
After internal deliberation I made the decision of a 2D side scrolling platformer as it fits well with unity development, and i wanted to try use unity for the first time.
The platformer structure also makes it easier to divide the game into manageable sections such as player movement, hazards, collectibles, level progression, state management and user interface.
It allows the project to demonstrate the scrum software development lifecycle through requirements analysis, design, backlog planning, implementation, testing and review.

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

### Core User Requirements
- The player must be able to run and jump smoothly
- The player must be able to move through side-scrolling levels
- The game must contain platforms, gaps and hazards
- The game must include enemy monster sprites (slimes)
- The game must include multiple levels
- The game must contain win and lose conditions
- The UI must display lives and level number
- The game should provide sound and visual feedback

### Optional User Requirements
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

## Scrum Style User Stories:

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
| B.4 | Hazard Detection | High | Hazards should damage, reset or defeat the player. | Touching a hazard causes the correct fail or life-loss response. | Hazards create risk and support the challenge loop. | Touch spikes or traps and verify the correct response. |
| B.5 | Enemy Monsters | High | Introduce slime enemies as moving or placed obstacles. | Enemy contact affects the player correctly. | Enemies make the game more dynamic than hazards alone. | Trigger player-enemy collision and verify result. |
| B.6 | End Goal | High | Reaching the goal completes the level. | The level ends or the next level loads correctly. | Gives the player a clear objective and win state. | Reach goal trigger and verify level completion. |
| B.7 | Retry / Restart | High | The player should be able to retry after failing. | A failed level can be restarted correctly. | Supports replayability and the core gameplay loop. | Fail the level and verify restart logic. |
| B.8 | Lives System | Medium | Track the number of lives the player has left. | Lives decrease correctly when the player is damaged or defeated. | Supports feedback and gives consequences to mistakes. | Trigger multiple failures/deaths and verify life value updates. |
| B.9 | Level Indicator | Medium | Display the current level on screen. | The UI shows the correct level number. | Helps the player understand progression. | Load levels and verify displayed level number. |
| B.10 | Cosmetic Collectibles | Medium | Add optional collectable items to encourage exploration. | Collectibles disappear when picked up and are counted or acknowledged. | Increases reward and replay value. | Touch collectible and verify pickup behaviour. |
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

The overall design strategy for LedgeBound is to create a platform game focused prototype that is stable, visually clear to navigate and easy to test. The project has been designed around the principle of starting with **building a stable core game**, then adding low and medium priority scrum features, this development stratergy supports better project management and makes it easier to compare the implemented game to the original design specification.

The game follows an Agile-inspired strategy where high-priority mechanics are implemented first, tested, reviewed and refined before lower-priority ideas are explored. This is a crucial stratergy as it helps keep the project realistic to develop for an individual, while still supporting ambitious ideas in a controlled way increasing the project scope.

### Design Priorities
1. Build stable movement and jumping systems
2. Ensure collisions, hazards and fail states work correctly
3. Add enemy monsters and level progression
4. Add clear UI feedback such as lives and level number
5. Add optional features such as collectibles, multiple levels, checkpoints and shops if time allows

### Development Order
- Define project idea and scope
- Produce requirements and user stories
- Create scrum backlog
- Set up Unity project and scene structure
- Implement movement and jumping
- Add platforms, hazards and collisions
- Add enemies and end-goal system
- Add UI and feedback systems
- Add optional features and polish prototype
- Test, debug and refine

---

## State Management

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

---

## Programming Language and Platform

### Game Engine
**Unity**

### Programming Language
**C#**
C# was chosen because it integrates directly with Unity and supports modular object-oriented scripting(code that defines how game objects behave and interact within the Unity game engine). This helps keep the code organised and maintainable.

### Target Platform
**Desktop PC**
Desktop PC was selected as the target platform because it allows easier testing during development, supports keyboard controls, and provides a straightforward approach for demonstrating the game.

### Input Method
**Keyboard controls**

### Justification
Unity was chosen because it provides strong support for:
- 2D game development  
- built-in systems  
- scene management and creation
- sprite handling
- user interface (UI) systems

---

Downloaded the following free Sprite Assests to use in unity:
<img width="1701" height="945" alt="image" src="https://github.com/user-attachments/assets/7e32ad99-7494-4991-8777-3e6dbb6d9ee6" />

Refrence Videos to help with developing the game:

https://www.youtube.com/watch?v=lIZnIFqai2I&list=PLXG1jSmcT-NXIHOPL8cZGXvDEGZ3gzurt&index=1
- Making a 2D Platformer In Unity 6 - Episode 1 (Full Course)
Channel: Unity Unlocked

---
