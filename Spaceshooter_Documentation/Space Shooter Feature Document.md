
# Space Shooter Feature Document

## Actions 
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

## Challenges
**Enemies**
- Enemies Spawn at a set interval, this interval can decrease in time over the course of the game.
	- Enemies shoot bullet at a set Interval.
	- Enemies use the same standard projectile attack as the player does.

	**Projectiles**
	- Enemy projectiles move downwards at a set speed.
	- Enemy projectiles take away 1 point of health from the player.
	- Enemy Projectiles are “destroyed” when they hit the enemy of are affected by the Blast attack.

## Systems
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

## Upgrades
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
