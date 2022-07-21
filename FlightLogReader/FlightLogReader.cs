﻿using System.Xml;
using Facade;

namespace FlightLogReader
{
    public static class FlightLogReader
    {
        private const string HasBeenDestroyedText = "HasBeenDestroyed";
        private const string PrimaryObjectText = "PrimaryObject";
        private const string SecondaryObjectText = "SecondaryObject";
        public static void ReadFlightLog(XmlDocument flightLog)
        {

        }

        public static List<HasBeenDestroyedEvent> ReadHasBeenDestroyedEvents(XmlDocument flightLog)
        {
            var hasBeenDestroyedEvents = new List<HasBeenDestroyedEvent>();

            var events = flightLog.GetElementsByTagName("Event");
            foreach (XmlNode flightLogEvent in events)
            {
                var hasBeenDestroyedEvent = false;
                foreach (XmlNode childNode in flightLogEvent.ChildNodes)
                {
                    if (childNode.InnerText == HasBeenDestroyedText)
                    {
                        hasBeenDestroyedEvent = true;
                        break;
                    }
                }

                if (hasBeenDestroyedEvent)
                {
                    hasBeenDestroyedEvents.Add(ReadHaseBeenDestroyedEvent(flightLogEvent));
                }
            }
            
            return hasBeenDestroyedEvents;
        }

        private static HasBeenDestroyedEvent ReadHaseBeenDestroyedEvent(XmlNode node)
        {
            /*
            Idee: SAM die geschossen haben über Location aufklären :) 
            <Event>
			<Time>2230.86</Time>
			<Location>
				<Longitude>43.7502859</Longitude>
				<Latitude>42.0671545</Latitude>
				<Altitude>846.22</Altitude>
			</Location>
			<PrimaryObject ID="391">
				<Type>Helicopter</Type>
				<Name>Mi-24P Hind-F</Name>
				<Pilot>Helo-2-1</Pilot>
				<Coalition>Allies</Coalition>
				<Country>ru</Country>
				<Group>Helo-2</Group>
			</PrimaryObject>
			<Action>HasBeenDestroyed</Action>
			<SecondaryObject ID="301">
				<Type>Tank</Type>
				<Name>T-72B</Name>
				<Pilot>toAttack-6</Pilot>
				<Coalition>Enemies</Coalition>
				<Country>xb</Country>
				<Group>toAttack</Group>
			</SecondaryObject>*/

            var hbdEvent = new HasBeenDestroyedEvent();
            foreach (XmlNode innerNode in node)
            {
                if (innerNode.Name == PrimaryObjectText)
                {
                    foreach (XmlNode primaryNode in innerNode.ChildNodes)
                    {
                        if (primaryNode.Name == "Type")
                            hbdEvent.PrimaryType = primaryNode.InnerText;
                        if (primaryNode.Name == "Name")
                            hbdEvent.PrimaryUnitTypeName = primaryNode.InnerText;
                        if (primaryNode.Name == "Pilot")
                            hbdEvent.PrimaryPilot = primaryNode.InnerText;
                        if (primaryNode.Name == "Coalition")
                            hbdEvent.PrimaryCoalition = primaryNode.InnerText;
                        if (primaryNode.Name == "Country")
                            hbdEvent.PrimaryCountry = primaryNode.InnerText;
                        if (primaryNode.Name == "Group")
                            hbdEvent.PrimaryGroup = primaryNode.InnerText;
                    }
                }
                else if (innerNode.Name == SecondaryObjectText)
                {
                    foreach (XmlNode secondary in innerNode.ChildNodes)
                    {
                        if (secondary.Name == "Type")
                            hbdEvent.SecondaryType = secondary.InnerText;
                        if (secondary.Name == "Name")
                            hbdEvent.SecondaryUnitTypeName = secondary.InnerText;
                        if (secondary.Name == "Pilot")
                            hbdEvent.SecondaryPilot = secondary.InnerText;
                        if (secondary.Name == "Coalition")
                            hbdEvent.SecondaryCoalition = secondary.InnerText;
                        if (secondary.Name == "Country")
                            hbdEvent.SecondaryCountry = secondary.InnerText;
                        if (secondary.Name == "Group")
                            hbdEvent.SecondaryGroup = secondary.InnerText;
                    }
                }
            }

            return hbdEvent;
        }
    }
}