# Untitled-Space-Game
Traverse through the different levels as you try to find your way back to Earth after being abducted by aliens! Test your skills by completing puzzles, navigating obstacles, and overcoming various other challenges that await you.\
Designed using: `Unity3D`

## The Storyline (Briefly)
After getting abducted by a UFO, the main character realizes he is in a strange laboratory room.\

`Level 1`: Puzzle Platformer\
Navigate through the different floors of the alien’s hideout to find a way to escape.

`Level 2`:Obstacle course & enemy area\
After escaping the hideout, get to the other side and reunite with his comrade by avoiding obstacles, and killing or avoiding enemies that are in the way.

`Level 3`:Color Memory Puzzle\
Retrieve fuel by solving a memory grid and shooting aliens in a color pattern.

`Level 4`:First-Person Shooter\
After getting fuel, the main character and his comrade realizes the rocket can only fit one person. The comrade reveals his evil intentions and becomes a giant that the main character has to defeat by shooting.

`Ending`:\
The main character flew the rocket and managed to land safely back on Earth. He documents his adventures into a game called Untitled Space Game.  


## Overall Preview
- This is a preview of the 4 different stages implemented.
    - Starting with `Level 1` (top-left)
    - Ending with `Level 4` (bottom-right)
<img src="/images/Untitled_Space_game_stages.gif" height="500px" width="auto"/>


## Live Demo (Recorded)
_Click the image (below) to be re-directed to the live demo_
[![Untitled Space Game](http://img.youtube.com/vi/mXOotM3wYLU/0.jpg)](http://www.youtube.com/watch?v=mXOotM3wYLU "SCSE Software System Analysis and Design - Untitled Space Game")

## Design Decisions
- Why did we choose this theme?
    - Provide a game that gives an out-of-this-world experience.
- Why did we implement multiple genres?
    - Different levels were based on different genres to provide a diverse gaming experience, thus catering to a wider audience. The variety of genres provides challenges that target different skill sets of the player.

## Requirements
- The 3 requirements to be fulfilled in the creation of this project.
<img src="/images/requirements.png" width="80%" height="80%">

## Humble Beginnings
Developing an immersive gaming platform requires multiple iterations and these were our _initial storyboards_. 
### Level 1
[Level 1 part 1]\
<img src="/images/initial/stage1/Stage 1 Storyboard 1.png" height="20%" width="50%"/>\
[Level 1 part 2]\
<img src="/images/initial/stage1/Stage 1 Storyboard 2.png" height="20%" width="50%"/>\
[Level 1 part 3]\
<img src="/images/initial/stage1/Stage 1 Storyboard 3.png" height="20%" width="50%"/>\
[Level 1 part 4]\
<img src="/images/initial/stage1/Stage 1 Storyboard 4.png" height="20%" width="50%"/>

### Level 2
[Level 2 part 1]\
<img src="/images/initial/stage2/Stage 2 Storyboard 1.png" height="20%" width="50%"/>\
[Level 2 part 2]\
<img src="/images/initial/stage2/Stage 2 Storyboard 2.png" height="20%" width="50%"/>\
[Level 2 part 3]\
<img src="/images/initial/stage2/Stage 2 Storyboard 3.png" height="20%" width="50%"/>

### Level 3
[Level 3 part 1]\
<img src="/images/initial/stage3/Stage 3 Storyboard 1.png" height="20%" width="50%"/>\
[Level 3 part 2]\
<img src="/images/initial/stage3/Stage 3 Storyboard 2.png" height="20%" width="50%"/>\
[Level 3 part 3]\
<img src="/images/initial/stage3/Stage 3 Storyboard 3.png" height="20%" width="50%"/>

### Level 4
[Level 4]\
<img src="/images/initial/stage4/Stage 4 Storyboard.png" height="20%" width="50%"/>\

## Design Decisions Based on Levels
**Warning**: _long story ahead_
### Level 1: Puzzle Platformer
The level’s design has to follow the narrative where the player initially gets abducted, and then tries to escape from where the player is being kept. Similar to how one would act in an unfamiliar environment, the player has to figure out the mechanics of each sub level while trying to progress through the hideout. However, the game has to be somewhat intuitive, otherwise it risks being an unenjoyable experience. Several key design decisions were made in lieu of that, such as colour coding/matching of several objects into 1 colour, having uncrossable platforms (bridges) be noticeably higher than normal platforms, making the exit to each sub level more prominent by elevating them to a higher level, etc.

With regards to the difficulties of each sub level, the difficulty of the first sub level is the lowest to act as an introductory tutorial stage to the player. The difficulty then gets progressively harder to challenge the player, with the final sub level offering the most difficulty. As previously mentioned, the levels were designed with enjoyability in mind. For example, invisible walls are placed around the platforms so as to prevent the player from falling off, where precise player movement is not one of the challenges we wanted to focus on. Instead, we focused on making the puzzles challenging yet satisfying to complete.


### Level 2: Obstacle course & enemy area
Level 2 was specially designed to give players a sense of the vastness, uncertainty and danger of space.

#### Why Obstacles?
The design of the obstacle course was inspired by a game called Fall guys which is a multiplayer game where the players will go through a fantasy world obstacle course. Obstacles used in the game were designed to be thrilling and challenges the player’s hand eye coordination. 

To suit the overall theme of our game, the actual obstacles were inspired from Fall guys but the design choices were changed to suit the space theme of the overall game. 

Some of the key design decisions in the obstacles were making sure the obstacles were of a consistent colour scheme and applying the same game assets as found in the other levels.

#### Why city and enemies chasing?
Inspired by survival-horror films and games like “predator” and “Left4Dead”, where players have to escape from life-threatening scenarios, this part of the stage aims to give players a sense of adrenaline and tension of a high stakes and high-paced gameplay, where players have very limited time to decide on their next move. The city was also carefully planned and designed to give players a sense of an “open-world” free roaming experience similar to games like “Fallout” and also to show the high-tech capabilities and futuristic look of an advanced alien-species . 

#### Why in the order of: Obstacle 1 -> Enemy 1 -> Obstacle 2 -> Enemy 2?
The order of the different areas were specially placed to give the player a more dynamic experience throughout the game. Instead of having 2 obstacle courses followed by 2 enemy areas, having them staggered gives players a sudden and unexpected change in pace and intensity during the game, inspired by films like “28 days later” where a situation can change dramatically in seconds. 

#### Choice of music
The music selected was meant to convey a change in mood according to the area the player is in. From a softer, low-tempoed music to a sudden louder, high-tempoed track, it shows the sharp contrast of the different areas in our level.