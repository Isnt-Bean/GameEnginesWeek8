# GameEnginesWeek8

Inside the code of the game, i have a state class that determines how the car moves.
The state class allows for only one of each of the switch statement states to be active at once. This makes it easy for car controls as you can only do one of each at a time in a real car.

The observer is used to determine if something has happened using the ?.Invoke() command.
The observer class is used to determine if the player car collides with an AI car, if it does it set to reset the scene.
