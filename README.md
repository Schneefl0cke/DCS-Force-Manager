# DCS-Force-Manager

## Beta
This is a beta version! I am not a UI guy. Thats why the UI is somewhat ugly, but functional. Feel free to contribute.

## Analyze

To analyze a mission (either a single mission or a campaign), you need to get the corresponding tacview and export the flight log.
The Force Manager can only read a TacView flight log!

The UI only displays a brief overview of the statistic, to get a much nicer view you need to export it!

# Features:
- Generate statistics about a single mission
- Generate statistics about campaign missions
- Generate a list player of players to get statistics about the players

# Planned Features:
- fancy diagrams
- Squadron/Airwing statistic
- Squadron/Airwing managment (e.g.: how many planes does the squadron/airwing has left,...)
- Generate Moose Code, so you can directly have an updated airwing in your Moose files

## Player names
Player names must be unique and must differ from other player names! Player names only need to be contained in the actual mission name, so you can change your callsign for overlord as you wish and get statistics anyway.

E.g.: 
Name in Force Manager: Schneeflocke

Name in Mission: Viper 1-1 | Schneeflocke -> this is valid
Name in Mission: Viper 1-1 | Schneeflocke | additional stuff -> this is also valid

But if a different player in the mission is called "Schneeflocke2" then the force manager will add this players statistic to the statistic of "Schneeflocke"!
