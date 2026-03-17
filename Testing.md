## Testing & Development
This section documents key issues encountered during development and explains how they were resolved aswell as a test plan/log.

---

## Test Plan/Test Log

| Test ID | Feature | Test Description | Expected Result | Actual Result | Status | Notes |
|--------|---------|------------------|-----------------|---------------|--------|-------|
| T1 | Player Movement | Press left and right controls | Player moves correctly in both directions | Pass | Complete | Core movement functioning |
| T2 | Jump Mechanic | Press jump while grounded | Player jumps and lands correctly | Pass | Complete | Jump functioning |
| T3 | Platform Collision | Land on platforms from multiple positions | Player stands correctly and does not fall through | Pass | Complete | Stable in current test scene |
| T4 | Hazard Collision | Touch spikes | Player loses life or fails correctly | Pass | In Progress | Confirmed working with spikes |
| T5 | Enemy Collision | Touch slime enemy | Player takes damage or fails correctly | Pass | In Progress | In work |
| T6 | End Goal | Reach level goal trigger | Level completes or next level loads | Pass | In Progress | In work |
| T7 | Retry System | Fail a level | Player restarts correctly | Pass | In Progress | Linked to lives logic |
| T8 | Lives Display | Take repeated damage | Lives decrease correctly and remain visible | Pass | Planned | UI still being refined |
| T9 | Level Indicator | Load different levels | Correct level number is displayed | Pass | Planned | Requires multi-level integration |
| T10 | Cosmetic Collectibles | Touch collectible item | Item disappears and reward is registered | Pass | Planned | Optional feature |
| T11 | Sound Feedback | Trigger jump, damage and finish actions | Correct sound plays | Pass | Planned | Audio to be finalised |
| T12 | Main Menu | Start the game from menu | Gameplay launches correctly | Pass | Planned | Menu flow still being refined |
| T13 | Game Over State | Lose all lives | Game over screen appears | Pass | Planned | Depends on final fail-state integration |
| T14 | Multiple Levels | Complete one level | Next level loads correctly | Pass | Planned | Lower priority |
| T15 | Checkpoint System | Activate checkpoint then fail | Respawn occurs at checkpoint | Pass | Planned | Lower priority |
| T16 | Shop / Unlockable Items | Access shop and unlock an item | Shop logic works correctly if implemented | Pass | Planned | Stretch target only |
| T17 | Stars / Extra Items | Collect stars/items on a level | Collection is recorded correctly | Pass | Planned | Stretch target only |

---

## Test Log Evaluation
The test log reflects the project priorities by focusing on the most important gameplay mechanics first. This supports a structured development process because the core systems are validated before optional polish features are added.

---
