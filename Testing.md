## Testing & Development
This section documents key issues encountered during development and explains how they were resolved aswell as a test plan/log.

The Scripts folder is responsible for the scripts i created in development,
it is found here: [Scripts](./Scripts)

---

## Test Plan/Test Log

| Test ID | Feature | Test Description | Expected Result | Actual Result | Status | Notes |
|--------|---------|------------------|-----------------|---------------|--------|-------|
| T1 | Player Movement | Press left and right controls | Player moves correctly in both directions | Pass | Complete | Core movement functioning |
| T2 | Jump Mechanic | Press jump while grounded | Player jumps and lands correctly | Pass | Complete | Jump functioning |
| T3 | Platform Collision | Land on platforms from multiple positions | Player stands correctly and does not fall through | Pass | Complete | Stable in current test scene |
| T4 | Hazard Collision | Touch spikes | Player loses life or fails correctly | Pass | Complete | Confirmed working with spikes |
| T5 | Enemy Collision | Touch slime enemy | Player takes damage or fails correctly | Pass | Complete | done in Sprint2 |
| T6 | End Goal | Reach level goal trigger | Level completes or next level loads | Pass | Complete | done in Sprint2 |
| T7 | Retry System | Fail a level | Player restarts correctly | Pass | Complete | Linked to lives logic |
| T8 | Lives Display | Take repeated damage | Lives decrease correctly and remain visible | Pass | Complete | UI still being refined |
| T9 | Level Indicator | Load different levels | Correct level number is displayed | Shows level text | Planned | Requires multi-level integration |
| T10 | Cosmetic Collectibles | Touch collectible item | Item disappears and reward is registered | No data | Planned | Optional feature |
| T11 | Sound Feedback | Trigger jump, damage and finish actions | Correct sound plays | No data | Planned | Audio to be finalised |
| T12 | Main Menu | Start the game from menu | Gameplay launches correctly | No data | Planned | Menu flow still being refined |
| T13 | Game Over State | Lose all lives | Game over screen appears | Able to lose all lives | Planned | Depends on final fail-state integration |
| T14 | Multiple Levels | Complete one level | Next level loads correctly | No data | Planned | Lower priority |
| T15 | Checkpoint System | Activate checkpoint then fail | Respawn occurs at checkpoint | No data | Planned | Lower priority |
| T16 | Shop / Unlockable Items | Access shop and unlock an item | Shop logic works correctly if implemented | No data | Planned | Stretch target only |
| T17 | Stars / Extra Items | Collect stars/items on a level | Collection is recorded correctly | No data | Planned | Stretch target only |
| T18 | Dash mechanic | Press dash key while moving | Player quickly dashes in the chosen direction | Pass | Complete | Sprint2 feature |
| T19 | Double jump | Press jump once on ground, then again in air | Player performs one extra jump only | Pass | Complete | Sprint2 feature |
---

## Test Log Evaluation
The test log reflects the project priorities by focusing on the most important gameplay mechanics first. This supports a structured development process because the core systems are validated before optional polish features are added.

---

## Early Stage Inital Development photos:
<img width="1425" height="915" alt="image" src="https://github.com/user-attachments/assets/a867f8b4-3c24-4186-b584-4f947d70233c" />

---

## Adding Game over and retry button:
<img width="2557" height="757" alt="image" src="https://github.com/user-attachments/assets/74954738-3db3-4ad4-a993-b3c94dac0ba0" />

---

## Adding Level Complete Panel:
<img width="2559" height="824" alt="image" src="https://github.com/user-attachments/assets/f9a74e50-1181-4a67-953a-096763ce8761" />

---
