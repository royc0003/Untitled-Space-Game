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
Are you feeling inspired?\
Curious to know more about why they've implemented `Untitled Space Game` in such a manner?\
Let's hear directly from the developers of the `Untitled Space Game`.\
**Warning**: _long story ahead_

### Level 1: Puzzle Platformer
The level’s design has to follow the narrative where the player initially gets abducted, and then tries to escape from where the player is being kept. Similar to how one would act in an unfamiliar environment, the player has to figure out the mechanics of each sub level while trying to progress through the hideout. However, the game has to be somewhat intuitive, otherwise it risks being an unenjoyable experience. Several key design decisions were made in lieu of that, such as colour coding/matching of several objects into 1 colour, having uncrossable platforms (bridges) be noticeably higher than normal platforms, making the exit to each sub level more prominent by elevating them to a higher level, etc.

With regards to the difficulties of each sub level, the difficulty of the first sub level is the lowest to act as an introductory tutorial stage to the player. The difficulty then gets progressively harder to challenge the player, with the final sub level offering the most difficulty. As previously mentioned, the levels were designed with enjoyability in mind. For example, invisible walls are placed around the platforms so as to prevent the player from falling off, where precise player movement is not one of the challenges we wanted to focus on. Instead, we focused on making the puzzles challenging yet satisfying to complete.


### Level 2: Obstacle Course & Enemy Area
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

### Level 3: Colour Memory Puzzle
Taken from the inspiration of Lumosity, a mobile application consisting of games that improves memory, attention and flexibility, Level 3 takes color memory puzzles into the 3D world of space. We chose a first person perspective to immerse the player into the game world and solve the puzzle from the protagonist’s point of view.

Similar to other memory puzzles, we allow 10 seconds for the player to remember the locations of all the aliens with a certain color. We chose 10 seconds because it is a considerate amount of time for players to remember the layout and some buffer to prepare for.

#### Adding Flexibility
To elevate the memory game, the player must remember the specific aliens with the color that matches the bullet. This extra task promotes flexibility and adaptability as the color of bullet changes for every puzzle. This level aims to stimulate the player’s mind through the importance of memory, focus and flexibility. 

#### A Transition Level
This level is designed to be simple and minimalistic to add contrast between Level 2 -- a more intensive level. Thus, we give the player a break from the previous level and for what is to come in Level 4. The cut scenes before Level 3 and after Level 3 also gives more context into the friendship of the comrade and the player.

#### Sound/Music
Because this level is simplistic in nature -- just like an old school arcade game. We decided that 8-bits sound effects will suit the game very well. There is feedback given to the player when the player hits the right or wrong wall through sound effects. This is to ensure the player has control over the game and that their shooting actions are being registered.

As for the background music, we go for something with a moderate tempo -- slow enough to allow the player to relax, fast enough to maintain the energy.

### Level 4: First-Person Shooter

#### Why FPS?
We wanted a more exciting way to end off the game as it is the last level, and a FPS game typically keeps the player on tenterhooks, where they have to be careful and watch out for their own health while trying to decrease the enemy’s health.

The idea of an enemy chasing the player is nerve wrecking and would make the game very fast paced.

#### What were we trying to achieve?
Inspired by krunker.io (a FPS game) coupled with the parkour mechanics that are presented within Minecraft adventure maps, we wanted to achieve a holistic gaming experience where the player would be able to run around on ground level and shoot the enemy, but also take a breather and escape from the enemy by parkouring to higher grounds. This allows for changing of paces in the game as instead of constantly being on the run during the entire level, the player can choose to parkour and get further away from the enemy.
<img src="/images/level4/Level 4 Overall.gif" height="20%" width="50%"/>\

#### What did we do to make the game immersive?
##### Mechanics
To have a level designed for a combat-oriented flow experience, we have implemented a sheer variety of weapons that the player can choose from.\
<img src="/images/level4/Level 4 Weapon Switch.gif" height="20%" width="50%"/>\

##### Contrasting size
We used both the element of contrasting size and elevations to elicit the menacing character from the protagonist.\
<img src="/images/level4/Level 4 Menacing Boss.gif" height="20%" width="50%"/>\

##### Appreciation
We placed platforms in the map to allow the player to be able to get to higher altitudes and see the map from different angles and appreciate the environment that was created, instead of just remaining on ground level for the entire game where their field of vision would be limited.\
<img src="/images/level4/Level 4 Platform Jump.gif" height="20%" width="50%"/>\
<img src="/images/level4/Level 4 Vantage Point.gif" height="20%" width="50%"/>\

##### SFX
One of the most crucial aspects of having an amazing game experience is to have sound effects that are as realistic as possible. And to achieve that, we’ve combined and layered the sounds together to achieve a crisp and realistic sound effect. For instance, every shot from the gun would be a combination of 3 different sounds(the firing sound, the falling empty shells and the impact of the bullet) randomly picked from a list of 10 different sound tracks. 

Additionally, the hitting effect from the protagonist would act as a cue to the player, warning him that he’s under attack.\
<img src="/images/level4/Level 4 Shoot Visual Effects.gif" height="20%" width="50%"/>\

##### Ambient Effect
To add-on to the experience and appreciation for the game, we’ve added a few intricate details to the environment: For instance, the luminous rocks that would glow in certain zones and would reflect off your weapon when you’re close to them, the train wreckages, the protruding rocks and a control centre. These interactions between the sounds and the environment make everything feel organic.\
<img src="/images/level4/Level 4 Luminescent.gif" height="20%" width="50%"/>\
<img src="/images/level4/Level 4 Bonus Pick Ups.gif" height="20%" width="50%"/>\

### Cutscenes
#### Developing Friendship
When the main character and the new-found friend first escape from the laboratory, they only talk about crucial things, and nothing more. However, after running out from the city, they had a chance to talk about life and open up to each other on the mountains, which showed the development of their friendship.

#### Foreshadowing of Betrayal
At the end of Level 3, when the main character invites his friend to hang out at the arcade after getting back to Earth, the friend replies coldly, which is pre-empting the betrayal of the friend in Level 4 in a subtle way. Then, the friend turns his back on the main character after the main character questions him on the rocket’s capacity, and then the boss fight in Level 4 begins.

As they were depicted to have gotten quite close before the betrayal, the betrayal would be more surprising and impactful for the main character.

#### Upholding of Friendship
After the main character kills his friend, he goes back to Earth, and keeps his promise of including his friend in his future works as mentioned in the cutscene where they talk on the mountains, which came to be the Untitled Space Game, which is the game itself.
