# launchers-and-projectiles
Exercise 6 of the "Intermediate Object-Oriented Programming for Unity Games" course of the "C# Programming for Unity Game Development" Specialization by the University of Colorado via Coursera

## Description

Problem 1 – Add pirate launcher and projectile

Use the pirate launcher and projectile sprites to create PirateLauncher and PirateProjectile prefabs. Be sure to add a Rigidbody2D component to the PirateProjectile prefab. 

Make sure you set the Sorting Layer in the Sprite Renderer component of those prefabs to Launcher and Projectile, respectively. This makes sure the projectile is rendered under the launcher, which looks better as the launcher fire projectiles.

Create PirateLauncher and PirateProjectile scripts and edit them to make the launcher firing rate twice as fast (cooldown half as long) as the ChainsawLauncher and the impulse force for the projectile 3 times as strong as for the ChainsawProjectile. 

Add a PirateLauncher prefab to the Hierarchy window and run the game to make sure your implementation works correctly.

Problem 2 – Add zombie launcher and projectile

Do what you did in the previous step, this time adding a zombie launcher and projectile. Make the launcher fire twice as fast as the pirate launcher and make the impulse force for the projectile 3 times as strong as for the pirate projectile (brains go really fast <grin>).

Add a ZombieLauncher prefab to the Hierarchy window and run the game to make sure your implementation works correctly.

Problem 3 – Add a launcher spawner

Delete all the launcher game objects from the Hierarchy window. Create a new LauncherSpawner script in the scripts folder and drag the script onto the main camera. Open the script in your IDE.

Add a documentation comment at the top of the class and add fields for the three launcher prefabs and a spawn timer. Populate the prefab fields in the Inspector. You'll probably also need other fields to implement the behavior described below.

Add code to the StartStart method to add a Timer component (put it in the field you just declared), set its duration to 5 seconds, and run it.

Add code to the UpdateUpdate method to check if the spawn timer is finished. If it is, re-run the spawn timer and spawn the appropriate launcher. Here's the required spawn order: ChainsawLauncher, PirateLauncher, and ZombieLauncher. Once all 3 launchers are spawned, don't spawn any more launchers.

When you run your code, be patient; it will be 5 seconds before the chainsaw launcher is spawned.

## Getting Started

n/a

### Dependencies

* Windows 10
* Microsoft Visual Studio
* .NET
* Unity

### Installing

* Download link: [Github Repository](https://github.com/lyndonpanton/launchers-and-projectiles)

### Executing program

n/a

## Help

n/a

## Authors

Lyndon Mykal Panton
[lyndonpanton](https://github.com/lyndonpanton/)

## Version History

* 0.1
    * Initial Release

## License

n/a

## Acknowledgments

Problem provided by the _University of Colorado_ and _Coursera_
