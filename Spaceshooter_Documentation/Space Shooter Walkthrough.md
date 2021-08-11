# Lesson 3 - Space Shooter
Welcome to the Space Shooter DnD Lesson, (Drag n Drop).
During this lesson you will learn what components are and how to use them to create a functional game.

First off we will take a look at the planning for the game and then get going with adding things together.

_Drag n Drop Lesson_
No code - we dont make things from scratch here, except the UI.


 

## Part 1: Planning & Ideation - The Process
This part, Planning and Ideation is by far the most important part of making a game, because this is where you find out what you are going to make, how you are going to make it and who you need to make it. 

### The Idea
The first thing we need is an idea: and this idea needs to be clear. There is a lot of work in cooking the idea down to its fundamentals and still make it sound exiting. So our Idea is to make a _Space shooter_, but we need a lot more on our Game Design document than the words: Space Shooter.

**What is a space shooter**
Before we go setting up a larger pitch we should look into other space shooters, what are these games like and what kind of elements could we borrow, and what elements do we not want to borrow?

Typically one could argue that a space shooter requires just a few elements.
- Shooting
- Waves of Enemies
- Space

	**looking for inspiration**
	So let’s go looking for inspiration, because if you are waiting, you may end up waiting forever, and we dont have that kind of time.


	**Playing Games**
	Find a few Space Shooters, there are plenty free on IOS or on Android, or you can go looking for Space Shooters with a higher budget on Steam, PlayStation or Xbox, any game is worth looking into as there are many things to learn.

	**Understanding The Games**
	While playing these games we have a series of questions we can ask ourselves.

	What is the Gameplay loop? Meaning what kind of actions and mechanics does this game contain. What can we as a player do, and what does the game throw at us.

	What makes the game fun, and why do we find those things fun? It is very important to know why things are fun, that can help you fine-tune the design later on and even bring the «fun» element into other parts of the game.

	What can we consider to be fundamental to the space shooter, and what is new and bold ideas? This is to figure out what the fundamentals are, you cant break the wall if you dont know what its made of. We need to know what people consider space shooters to be to be able to innovate and make them new and fresh, if we desire.


**The Pitch**
In this case we have a pitch, which explains what the game is a bit excitedly.

> _Space Pirates is a game where you advance through a gauntlet of enemy vessels that have come to claim your treasure. Defeat them to become the Pirate King._

Now that is an ok pitch, but to make the game we need to know more about the game, which leads us to making the concept document and planning the game: We need _Mechanics_, _Aesthetics_ and _Narrative_.

So now with ideas and inspiration we will look at the Game Design Document that was pre-made for this task.

- The Process
	- What is the idea?
	- What are the Mechanics
	- Lets Play a Space Shooter
	- Upgrades, Assets, Sprites, Sounds, Verbs
	- The Design Document + Asset List
	- Task List - What to do, When to do

## Part 2: The Game Design Documents
This step is very important, again, it is when we coalesce our planning, ideation, into a production document which outlines every part of the game, a recipe if you will. 

If you give these documents to three different teams, they should be able to make inherently the same game. 
> (Note that this Game Design Document is very short and light on details in comparison to more professional documents, but this is a nice place to start)
> > (( Also note that when talking about mechanics and assets we always include a details on what the mechanic’s purpose is and what its going to do as finely detailed as we can, and with assets we must describe what we want to make it easier for the Artists making them))

### Concept Document
This is a Concept Document and contains the basics of the game idea and thus, concept. With a Pitch and Description, it may also contain Narrative if there is one.

#### Pitch
> _Space Pirates is a game where you advance through a gauntlet of enemy vessels that have come to claim your treasure. Defeat them to become the Pirate King._

#### Description
Space Pirates is a Space Shooter style game for Mobile, Web and Desktop Computers. Utilising the classic style of the genre we are shining a light on the very core and what makes the genre great: Tight movement skills that allows the player to delicately navigate a maze of bullets hurled at the player by enemies.

Players will be auto shooting single laser projectiles, which can be upgraded to many colourful variations like double-shot and spread-shot. The Players will also have the ability to charge up a super attack which can destroy enemy projectiles and vast amounts of enemies.

The point of the game is to survive for X minutes, or in Endless Mode, survive as long as possible to get the highest score.

### Feature Documents (Mechanics)
#### Actions 
**Auto Shoot** 
- At a certain interval, projectiles are shot from the front of the ship at a certain speed.

	**Move**
	- 8 Directional.
		- Move slower backwards than forwards.

		**Super Attack** 
		- _Blast_: Destroys projectiles in a circle around the player.
		- _Beam_: Destroys enemies in a Line, but does not affect projectiles

		**Pick up**
		- Health packs - Return 20-30 % of the health
		- Shield - Makes the player Invulnerable to damage for 3 Seconds - OR - makes the player Invulnerable to 5 hits.

	#### Challenges
	**Enemies**
	- Enemies Spawn at a set interval, this interval can decrease in time over the course of the game.
		- Enemies shoot bullet at a set Interval.
		- Enemies use the same standard projectile attack as the player does.

		**Projectiles**
		- Enemy projectiles move downwards at a set speed.
		- Enemy projectiles take away 1 point of health from the player.
		- Enemy Projectiles are “destroyed” when they hit the enemy of are affected by the Blast attack.

	#### Systems
	**Health**
	- The Health system will track the players health
		- Health will be affected by enemy projectiles (remove 1 life)
		- Health will be affected by Health Packs (add one life)
		- Other systems will use this to restart the game scene

		**Score**
		- The Score system will track the amount of score the player has achieved.
		- Score will be increased when the player destroys an enemy
		- Score will be increased based on each second the player survives.
		- Score will be saved to a high score visible from the main menu.

		**Enemy Spawn**
		- The Enemy spawn system will track the amount of enemies needed to be spawn through an Object Pool.
			- Object pools are small systems that create a set amount of objects and we use these objects, and when we dont need them we return them to the list.
		- Enemies will be spawned from a set of spawn points
		- Enemies will be spawned at a set rate which will increase with time.

	#### Upgrades
	**Speed Shot**
	This upgrade doubles the rate of fire of the player.

	**Strong/Unstable Shot**
	This upgrade increases the damage of the player projectile. 
	_Or_ - Increases the hit-box of the projectile so that it can hit enemies who are too close horizontally.

	**DubleShot**
	This upgrade changes the shooting pattern of the player.
	Two bullets are shot upwards.

	**TripleShot**
	This upgrade changes the shooting pattern of the player.
	One Bullet is shot upwards and two are shot diagonally.

	**QuadShot**
	This upgrade changes the shooting pattern of the player.
	Two Bullets are shot upwards and two are shot diagonally.

	**BackShot**
	An additional bullet is fired from the back of the ship allowing you to take down enemies behind you.

### Asset Document
#### Sprites
**Player**
- The player will be a sleek and modern 70’s inspired shape-ship feel. It will also be compact like a small personal cruiser with white and blue colours.

**Enemy**
- The enemy ship will use a very similar design to the Players, but with a bit more jagged and dangerous look and mainly use darker colours and red.

**Engine Flame** 
(For Player & Enemy Ships)
- The Engine flame will be a small sci-fi glow coming from the end of the ships to indicate movement. Ideally the flame will be white so we can change colour in game.

**Standard Laser projectile**
- The Standard Laser projectile is going to have somewhat of an elongated water-drop shape with its tail fading out as if its loosing energy as it goes. 
- The Laser will be white and grey scale so we can change colour in game.

**Upgraded Laser projectile**
- The Upgraded Laser Projectile is going to be very similar to the standard laser projectile, but will be larger and not have that kind of fade out feel, like it - maintains its energy. The Laser will be white and grey scale so we can change colour in game.

**Blast Attack**
(Area of Affect attack - Circle)
- The Blast Attack is spreads out as an _energy wave_ in a circle around the ship, increasing in size until it fades out. If time - make animated with crackling  energies at the edge of this wave. The Blast will be white and grey scale so we can change colour in game.

**Beam Attack** 
(Long Beam stretching beyond the screen)
- The Beam Attack is a thick beam that is almost at the width of the player ship. It should be domelike on one end, as if it’s coming from a very small point.
  - _Reference_: Gundam Big Beam Attacks!
  - _((If you have references, include them!! It will make it much easier to explain what you are thinking to the artists))_

**Space background**
- A Simple black background with some stars in the distance. Must be “Loopable” meaning that we should be able to repeat the background without seeing it crashing with itself. The Stars should be white so we can change colour in game.

**Small Explosion**
(For Laser hits)
- This is a small and simple Puff explosion which is left after a projectile hits an object. Must be animated, 2-5 frames.

**Big Explosion** 
(For Ship Destruction)
- This if for ships when they die, a proper space explosion. ((There is no fire in space)). This must be animated, and have between 5-10 frames of animation. 
  - _Reference: Gundam Space Explosion_


#### Sounds
**Background Music**
- A catchy 70’s inspired sci fi audio clip, must be at least 1-2 minutes in length and should loop without issue.

**Laser Shoot**
- A simple and short laser shooting sound. A bit high pitched beginning and ending in a small rumble. Should not be longer than 1 second.

**Engine rumble**
- The sound coming off the Player ship when standing still or moving slow. Should be a short 2-5 second sound that loops perfectly.

**Engine Thrust**
- The Sound coming off the Player ship when moving forwards. Should be a short 2-5 second sound that loops perfectly.

**Blast Attack Sound**
- This sound should last for 2-3 seconds with a big start and a fade out to the end. It is a big energy wave and should feel impactful. No need for a loop.

**Beam Attack Sound**
- This sound should be Big and powerful. 1-2 Seconds with perfect loop. 
- _((Might be split into 3 sounds where we have Charge - Shoot - Fade.))_
  - Reference: Gundam Beam Attacks

**Small Explosion sound**
- This is for the small puff explosion when an object is hit with a projectile. 0.5-1 Seconds.

**Big Explosion Sound**
- This is for when a ship explodes. Should be energetic but also feel a bit mechanical, like things breaking up amidst the energy. 1-1.5 seconds


## Part 3: Prototype

- New Unity Project
	- Import Unity Package
	- Overview of what we have
	- Make the Game
	   - Core - Input, Move, Shoot, Enemies (Move)

Movement
Shooting
Generic Spawning


Step 01:
• Add sprite to the hierarchy, and zero it,s position
• add background to the hierarchy
• add input to the player object
• add player Movement to the player object,
• Test the Movement
• add the shoot script, it does not work because we have yet to create A bullet for the ship to shoot

• add the projectile sprite to hierarchy, and zero it’s position as well as rotating it 90°.
- add the projectile controller script to the projectile
- add the projectile lifetime and damage script to the projectile
Then create a prefab by dragging the projectile into the project window under the prefabs folder.

Then delete the projectile from the hierarchy window, then drag the prefab from the project window into the public field on the players shoot script.

## Part 4: Develop & implement

- Upgrades
	- Faster shooting
		- Stronger bullet
			- Twoshot
			- Trishot
			- Quadshot
		- Consumables
			- +life
			- Shield
			- Surge(wave that destroys enemy projectiles)
			- Super Shield
			- 

## Part 5: Aesthetics
Add Animations & Flashy Elements
(Animations are Pre-made + Animators)
Same with any flashy elements
- Ship Engine Burn
- 

## Part 6: Polish & Game Feel


User Interface
Score
Win / Loose Conditions
Game play Loop

- Build
	- Test
