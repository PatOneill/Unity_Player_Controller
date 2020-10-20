# Unity_Player_Controller
The C# code posted in this repo is a work in progress build of a custom kinematic player controller for Unity.

Latest 10/20/20:
The Player states of crouch idle, crouch walk, couch fall, and crouch air move have been added. 

The physics logic for maintaining the player's horizontal velocity in any fall state has been added. The player can also cancel their horizontal momentum in a fall state by pulling back on the analog stick. Finally, the player will have the ability to move slightly along the X and Z axis while falling.

The physics logic for smoothly decaying the player's horizontal speed when changing between state (eg sprint state to walk state) has been added to avoid sudden speed changes.

Changed the physics logic for slope and handling corners. The new logic system is easier to understand and more flexible. 

Add new physics logic to ensure that as the player moves around the map, they stay grounded.

Finally, slight changes to the physics system software design and minor changes to the  state machine

Update 9/28/20: 
Removed redundant call to the player physics system
Redesign the input and state systems to be more flexible using interfaces instead of using concrete classes
Changed how the player's physics system operates to mitigate design issues that would have shown up later on in the project.

Update 8/25/20: Initial Code push, with some of the basic functionalities of a player controller
    


