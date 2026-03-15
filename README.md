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

## Scrum Style User Stories

| User Story ID | Priority | User Story | Purpose / Justification |
|---|---|---|---|
| US1 | High | As a player, I want to move left and right so that I can navigate through the level. | This is a core mechanic required for all gameplay and level traversal. |
| US2 | High | As a player, I want to jump smoothly so that I can cross gaps and reach platforms. | Jumping is essential in a platform game and supports progression through the level. |
| US3 | High | As a player, I want hazards to damage or reset me so that the game is more challenging. | Hazards introduce risk and create meaningful fail conditions. |
| US4 | High | As a player, I want monsters to act as obstacles so that the level feels more dangerous. | Enemies make the gameplay more dynamic and challenging than static hazards alone. |
| US5 | High | As a player, I want to reach an end goal so that I can finish the level. | A clear goal is needed so the player understands how to complete the stage. |
| US6 | Medium | As a player, I want lives so that mistakes have consequences. | A lives system makes failure meaningful and supports the retry/game over structure. |
| US7 | Medium | As a player, I want cosmetic collectibles so that exploration feels rewarding. | Collectibles encourage exploration and improve replayability. |
| US8 | Medium | As a player, I want level indicators so that I can track my progress. | Level indicators provide useful feedback and help the player understand progression. |
| US9 | Medium | As a player, I want sound and visual feedback so that actions feel satisfying. | Feedback improves responsiveness and makes interactions feel clearer and more polished. |
| US10 | Medium | As a player, I want a visually appealing background for each level so that the world feels more dynamic. | Background design strengthens presentation and helps levels feel more distinct. |
| US11 | Low | As a player, I want multiple levels so that the game has more replay value. | Multiple levels add progression and increase the amount of playable content. |
| US12 | Low | As a player, I want checkpoints so that longer levels feel fairer. | Checkpoints reduce frustration and improve usability in harder or longer stages. |
| US13 | Low | As a player, I want more advanced enemy behaviour so that later levels feel more difficult. | More advanced enemy logic can make later stages feel more varied and demanding. |
| US14 | Low | As a player, I want a shop with items that can be unlocked so that the game is more fun. | A shop system is an optional extension that can increase depth and player motivation. |
| US15 | Low | As a player, I want stars/items that can be collected on each level so that the game is more replayable. | Extra items create optional completion goals and encourage replay. |

---

Downloaded the following free Sprite Assests to use in unity:
<img width="1701" height="945" alt="image" src="https://github.com/user-attachments/assets/7e32ad99-7494-4991-8777-3e6dbb6d9ee6" />

Refrence Videos to help with developing the game:

https://www.youtube.com/watch?v=lIZnIFqai2I&list=PLXG1jSmcT-NXIHOPL8cZGXvDEGZ3gzurt&index=1
- Making a 2D Platformer In Unity 6 - Episode 1 (Full Course)
Channel: Unity Unlocked

---
