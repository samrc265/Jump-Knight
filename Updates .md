Updates:
Main Dump:
    This update uploaded the initial game built before creation of the repo

V1:
    1) renamed the script file names to match with the class name
    2) referenced the missing script in inspector 
    3) set canvas resolutions to  1920 ×1080
    4) added capsule collider to the player,constricted  the rotation Z (so that player don't rotate in Z axis)and attached the physic material 2D to Rigidbody to set the friction to 0 to fix a bug of player sticking to wall
    5) added the character selection in main menu and created 3 character prefabs and you can select any characters to play 
    6) referencing player in public in any script has been replaced with GameObject.FindGameObjectsWithTag to refer the instantiate player, instead of using public transform player  Bec we would be instantiating a player in game 
    7) added the high score display at main menu 
    8)set the order of layer of background image to -1 to avoid any potential background image bug
    9) extended the UI panel's width so that it can fit with all device by checking the simulation device

V2:
    1) added vibrate on death feature for phones
    2) added on click quit condition on quit button in main menu
