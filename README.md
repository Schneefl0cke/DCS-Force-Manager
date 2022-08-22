# DCS-Force-Manager

## Beta
This is a beta version! I am not a UI guy. Thats why the UI is somewhat ugly, but functional. Feel free to contribute.

## Analyze

To analyze a mission (either a single mission or a campaign), you need to get the corresponding tacview and export the flight log.
The Force Manager can only read a TacView flight log!

The UI only displays a brief overview of the statistic, to get a much nicer view you need to export it! The export will generate an excel file that will contain the data and will be easier to read, edit and work on.

# Features:
- Generate statistics about a single mission
- Generate statistics about campaign missions
- Get statistics of Players
- Get statistics of Squadrons

# Planned Features:
- fancy diagrams
- Detailed death statistic of players and squadrons
- Squadron/Airwing managment (e.g.: how many planes does the squadron/airwing has left,...)
- Generate Moose Code, so you can directly have an updated airwing in your Moose files

## Player names
Player names must be unique and must differ from other player names! Player names only need to be contained in the actual mission name, so you can change your callsign for overlord as you wish and get statistics anyway.

E.g.: 
Name in Force Manager: Schneeflocke

Name in Mission: Viper 1-1 | Schneeflocke -> this is valid

Name in Mission: Viper 1-1 | Schneeflocke | additional stuff -> this is also valid

But if a different player in the mission is called "Schneeflocke2" then the force manager will add this players statistic to the statistic of "Schneeflocke"!

## Squadron names
Works the same as players, but will check the group name instead of the pilot name. A Squadron can contain as many aircraft types and even ground units or ships at once as you wish, if they only share a similar group name. The death count is inacurate after that of course. In the future it is planned to provide a better death statistic so you can see what unit of which type was killed. That way you can display a whole brigade or airwing. 