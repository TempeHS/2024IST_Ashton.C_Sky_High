# TempeHS-2024IST_Ashton.C_
<h1 align="center">
 <img src="https://user-images.githubusercontent.com/45159366/97361059-45151700-185c-11eb-9d12-dae51c79eb8a.png">
  <br />
 2024IST_Ashton.C_Sky_High
</h1>

# Overview

This game was originally made as a project for an assessment, meant to fit the "Games for Change" theme, but it didn’t really meet that goal. You play as a character jumping and aiming as high as they can. The plan was to add challenging obstacles like falling platforms and the tough jumps that needed to be made.

In the end, though, I focused more on parkour instead of adding enemies or visual effects like bloom and shadows. The game is mainly about teaching players how to move and play through a tutorial, rather than having complex visuals or enemy encounters. If I had finished it, I would have added those things, but it stayed as a parkour-focused game with a learning experience.

# Walkthrough

[video link]

## User Documentation

### Keyboard and Mouse

| Action       | Output                         |
|--------------|---------------------------------|
| A            | Move Left                      |
| D            | Move Right                     |
| S            | Move Down on *some* platforms  |
| Left Shift   | Dash                           |
| Space        | Jump                           |

### Controller

| Action             | Output                         |
|--------------------|---------------------------------|
| Left Joystick      | Move Left/Right                |
| Left Joystick Down | Move Down on *some* platforms  |
| Y                  | Jump                           |
| Dash               | *Currently unresponsive*       |

### Game Objective

- **Levels**: The game has two levels and a tutorial to start with.
- **Platforms**: Survive and learn about the different types of platforms.

# Developer Documentation


### What I Intended to Create: Sky High

Initially, **Sky High** was meant to be a 2D action game aimed at addressing the social issue of verbal bullying. The concept was to create a platformer where players navigate through levels filled with emotional and psychological challenges, symbolizing the impact of bullying. My goal was to raise awareness about how words can affect someone, turning the game into an emotional journey.

### What I Made: Sky High

As I began working on the game, I realized my original vision was too complex. I decided to scale back and change the direction, focusing more on parkour mechanics rather than addressing social issues or adding enemies.

This game was originally made as a project for an assessment, with the intention of fitting into the "Games for Change" theme. However, the final version shifted to a parkour-focused game where players aim to jump and reach new heights. The objective was to add challenging elements, like falling platforms and tricky jumps that require precision.

In the end, I prioritized fluid parkour gameplay over visual complexity. I didn’t include enemies or extra visual effects like bloom and shadows. Instead, **Sky High** became more of a tutorial-based experience to teach players movement techniques. Had I finished it completely, I would have added those additional features, but it remains a game centered on mastering movement.

### Key Features

- **Character Movement**: Smooth movement mechanics using W, A, and D. W is used for jumping, and A and D for horizontal movement. The game focuses on parkour skills like jumping between platforms.

- **Level Progression**: Players advance by going through a portal at the end of each level, tying into the parkour theme of climbing higher and aiming for the top.

- **Music**: My partner has made a soundtrack for audio background to give the game a sense of excitement, though the focus remained primarily on gameplay mechanics rather than visuals or audio complexity.


  # Features

I used [these tutorials](https://www.youtube.com/watch?v=TYg07K-5ONU&list=PLyHH_4nd7MkI-jgXnEw3nSVzAqeftSSyM) for many of the features in the game. They were helpful, especially for basic movement code, as I was still learning C# and Unity. The tutorials were easy to follow, and I adjusted the code to fit what I needed for the game.

### Movement and Jumping

Movement and jumping were the first things I added to the game. I followed the tutorials closely and didn’t have much trouble. Most of the issues I had were small mistakes like typos, which were easy to fix.

### Dashing

Dashing was the second thing I worked on, as I thought it would be a good idea to add to make the parkour game more complex and challenging. The main issue I faced was deciding whether or not to include a visual trail during the dash.

### One Way Platforms

One way platforms are one of the most frequently used elements in the game. I used them to help players go higher and to increase the challenge, giving a sense of climbing toward the sky to suit the game’s theme.

### Falling Platforms

Falling platforms add an extra level of difficulty and excitement. When the player steps on these platforms, they fall after a short delay, forcing the player to move quickly and plan their jumps. This mechanic was added to keep the gameplay dynamic and unpredictable, increasing the tension as the player progresses through the levels.

### Jumping Platforms

I used particle effects to present the jumping platforms and give the players an idea of a particle presenting a jump boost.


# Final Thoughts

**Sky High** is a learning experience focused on mastering movement. It’s about skillful navigation and overcoming obstacles with precision, rather than confronting enemies or relying on complex visual effects.


# Scripting Editing Software
![image](https://github.com/user-attachments/assets/1789bb97-b77f-46ff-aa53-b6945eb882a6)


# Scripts

- [CountDown Timer](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/CountdownTimer.cs)
- [Falling Platform](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/FallingPlatform.cs)
- [Jump Pads](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/JumpPads.cs)
- [Kill Player](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/KillPlayer.cs)
- [Level Move](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/LevelMove.cs)
- [Sign](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/Sign.cs)
- [Timer](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/Timer.cs)
- [Camera Follow](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/Player/CameraFollow.cs)
- [Player Controller](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/Player/PlayerController.cs)
- [Player One Way Platform](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/Player/PlayerOneWayPlatform.cs)
- [Main Menu](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/Menu/MainMenu.cs)
- [Pause Menu](https://github.com/TempeHS/2024IST_Ashton.C_Sky_High/blob/devv/Pokemon%20Unity%20File/Pokemon%20FINALEE/Assets/Scripts/Menu/MainMenu.cs)

# Collaboration

Serena Lai Multimedia partner
Created: GFX, Audio and animations
[add media examples]

