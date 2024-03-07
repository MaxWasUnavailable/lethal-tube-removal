﻿using BepInEx.Configuration;
using LethalConfig.ConfigItems;
using LethalConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LethalTubeRemoval
{
    public class Config
    {
        //Inside Ship
        public static ConfigEntry<bool> deleteTube;                 //initializes the config entry for each ship item, uses LethalConfig
        public static ConfigEntry<bool> deleteBunkbeds;
        public static ConfigEntry<bool> deleteFileCabinets;
        public static ConfigEntry<bool> deleteOxygenTank;
        public static ConfigEntry<bool> deleteClipboard;
        public static ConfigEntry<bool> deleteDoorGenerator;
        public static ConfigEntry<bool> deleteBoots;
        public static ConfigEntry<bool> deleteMask;
        public static ConfigEntry<bool> deleteAirFilter;
        public static ConfigEntry<bool> deleteStickyNote;
        public static ConfigEntry<bool> deleteBatteries;
        public static ConfigEntry<bool> deleteVent;
        public static ConfigEntry<bool> deleteMonitorCords;
        public static ConfigEntry<bool> deleteDoorSpeaker;
        public static ConfigEntry<bool> deleteMainSpeaker;
        public static ConfigEntry<bool> deletePosters;
        public static ConfigEntry<bool> deleteClothingRack;
        public static ConfigEntry<bool> deleteDoorTubes;
        public static ConfigEntry<bool> deleteKeyboardCord;
        public static ConfigEntry<bool> terminalReposition;

        //Outside Ship
        public static ConfigEntry<bool> deleteFloodLight;
        public static ConfigEntry<bool> deleteOutsideTubing;
        public static ConfigEntry<bool> deleteMachinery;
        public static ConfigEntry<bool> deleteRailing;
        public static ConfigEntry<bool> deleteThrusterTube;
        public static ConfigEntry<bool> deleteThrusters;



        public Config(ConfigFile cfg)
        {
            //Inside Ship

            deleteTube = cfg.Bind(                                  //sets initial LethalConfig values
               "General",                                           //type of change
               "Tube",                                              //Name in the UI
               true,                                                //default value
               "Deletes the tube on the floor"                      //Description for UI
           );
            var tubeToggle = new BoolCheckBoxConfigItem(deleteTube, requiresRestart: false);    //sets as checkbox for bool, sets restart flag as false as these changes do not require a restart of the game
            LethalConfigManager.AddConfigItem(tubeToggle);

            deleteBunkbeds = cfg.Bind(
                "General",
                "BunkBeds",
                false,
                "Deletes the bunkbeds"
            );
            var bedToggle = new BoolCheckBoxConfigItem(deleteBunkbeds, requiresRestart: false);
            LethalConfigManager.AddConfigItem(bedToggle);

            deleteFileCabinets = cfg.Bind(
                "General",
                "File Cabinets",
                false,
                "Deletes the file cabinets"
            );
            var fileCabinetsToggle = new BoolCheckBoxConfigItem(deleteFileCabinets, requiresRestart: false);
            LethalConfigManager.AddConfigItem(fileCabinetsToggle);

            deleteOxygenTank = cfg.Bind(
                "General",
                "Oxygen Tank",
                false,
                "Deletes the oxygen tank"
            );
            var oxygenTankToggle = new BoolCheckBoxConfigItem(deleteOxygenTank, requiresRestart: false);
            LethalConfigManager.AddConfigItem(oxygenTankToggle);

            deleteClipboard = cfg.Bind(
                "General",
                "Clipboard",
                false,
                "Deletes the clipboard"
            );
            var clipboardToggle = new BoolCheckBoxConfigItem(deleteClipboard, requiresRestart: false);
            LethalConfigManager.AddConfigItem(clipboardToggle);

            deleteDoorGenerator = cfg.Bind(
                "General",
                "Door Generator",
                false,
                "Deletes the door generator"
            );
            var doorGeneratorToggle = new BoolCheckBoxConfigItem(deleteDoorGenerator, requiresRestart: false);
            LethalConfigManager.AddConfigItem(doorGeneratorToggle);

            deleteBoots = cfg.Bind(
                "General",
                "Boots",
                false,
                "Deletes the boots under the clothing rack"
            );
            var bootsToggle = new BoolCheckBoxConfigItem(deleteBoots, requiresRestart: false);
            LethalConfigManager.AddConfigItem(bootsToggle);

            deleteMask = cfg.Bind(
                "General",
                "Mask",
                false,
                "Deletes the mask on the control desk"
            );
            var maskToggle = new BoolCheckBoxConfigItem(deleteMask, requiresRestart: false);
            LethalConfigManager.AddConfigItem(maskToggle);

            deleteAirFilter = cfg.Bind(
                "General",
                "Air Filter",
                false,
                "Deletes the air filter on the wall"
            );
            var airFilterToggle = new BoolCheckBoxConfigItem(deleteAirFilter, requiresRestart: false);
            LethalConfigManager.AddConfigItem(airFilterToggle);

            deleteStickyNote = cfg.Bind(
                "General",
                "Sticky Note",
                false,
                "Deletes the sticky note"
            );
            var stickyNoteToggle = new BoolCheckBoxConfigItem(deleteStickyNote, requiresRestart: false);
            LethalConfigManager.AddConfigItem(stickyNoteToggle);

            deleteBatteries = cfg.Bind(
                "General",
                "Batteries",
                false,
                "Deletes the batteries on control desk"
            );
            var batteryToggle = new BoolCheckBoxConfigItem(deleteBatteries, requiresRestart: false);
            LethalConfigManager.AddConfigItem(batteryToggle);

            deleteVent = cfg.Bind(
                "General",
                "Vent",
                false,
                "Deletes the vent below the charging station"
            );
            var ventToggle = new BoolCheckBoxConfigItem(deleteVent, requiresRestart: false);
            LethalConfigManager.AddConfigItem(ventToggle);

            deleteMonitorCords = cfg.Bind(
               "General",
               "Monitor Cords",
               false,
               "Deletes the cords behind the monitors"
           );
            var monitorCordsToggle = new BoolCheckBoxConfigItem(deleteMonitorCords, requiresRestart: false);
            LethalConfigManager.AddConfigItem(monitorCordsToggle);

            deleteDoorSpeaker = cfg.Bind(
               "General",
               "Door Speaker",
               false,
               "Deletes the speaker near the ship door"
           );
            var doorSpeakerToggle = new BoolCheckBoxConfigItem(deleteDoorSpeaker, requiresRestart: false);
            LethalConfigManager.AddConfigItem(doorSpeakerToggle);

            deleteMainSpeaker = cfg.Bind(
               "General",
               "Main Speaker",
               false,
               "Deletes the main speaker that normally plays audio. WARNING: No ship-speaker audio will play if this is selected!"
           );
            var mainSpeakerToggle = new BoolCheckBoxConfigItem(deleteMainSpeaker, requiresRestart: false);
            LethalConfigManager.AddConfigItem(mainSpeakerToggle);

            deletePosters = cfg.Bind(
               "General",
               "Posters",
               false,
               "Deletes the posters inside the ship"
           );
            var postersToggle = new BoolCheckBoxConfigItem(deletePosters, requiresRestart: false);
            LethalConfigManager.AddConfigItem(postersToggle);

            deleteClothingRack = cfg.Bind(
               "General",
               "Clothing Rack",
               false,
               "Deletes the clothing rack. WARNING: Purchasable suits will not be able to be equipped if this is selected!"
           );
            var clothingRackToggle = new BoolCheckBoxConfigItem(deleteClothingRack, requiresRestart: false);
            LethalConfigManager.AddConfigItem(clothingRackToggle);

            deleteDoorTubes = cfg.Bind(
               "General",
               "Door Tubes",
               false,
               "Deletes the tubes by the ship door."
           );
            var doorTubesToggle = new BoolCheckBoxConfigItem(deleteDoorTubes, requiresRestart: false);
            LethalConfigManager.AddConfigItem(doorTubesToggle);

            deleteKeyboardCord = cfg.Bind(
               "General",
               "Keyboard Cord",
               true,
               "Deletes the cord coming out of the keyboard on the terminal"
           );
            var keyboardCordToggle = new BoolCheckBoxConfigItem(deleteKeyboardCord, requiresRestart: false);
            LethalConfigManager.AddConfigItem(keyboardCordToggle);


            terminalReposition = cfg.Bind(
               "General",
               "Terminal Reposition",
               false,
               "Sets the terminal to the left of the monitors by default."
           );
            var terminalRepositionToggle = new BoolCheckBoxConfigItem(terminalReposition, requiresRestart: false);
            LethalConfigManager.AddConfigItem(terminalRepositionToggle);



            // OUTSIDE SHIP
            deleteFloodLight = cfg.Bind(
               "General",
               "Outside: Floodlight",
               false,
               "Removes the floodlight outside the ship"
           );
            var deleteFloodlightToggle = new BoolCheckBoxConfigItem(deleteFloodLight, requiresRestart: false);
            LethalConfigManager.AddConfigItem(deleteFloodlightToggle);

            deleteMachinery = cfg.Bind(
               "General",
               "Outside: Machinery Boxes",
               false,
               "Removes the machinery boxes on both sides of the ship"
           );
            var machineryToggle = new BoolCheckBoxConfigItem(deleteMachinery, requiresRestart: false);
            LethalConfigManager.AddConfigItem(machineryToggle);

            deleteOutsideTubing = cfg.Bind(
               "General",
               "Outside: Tubing",
               false,
               "Removes the tubing outside the ship"
           );
            var outsideTubingToggle = new BoolCheckBoxConfigItem(deleteOutsideTubing, requiresRestart: false);
            LethalConfigManager.AddConfigItem(outsideTubingToggle);

            deleteRailing = cfg.Bind(
               "General",
               "Outside: Railing",
               false,
               "Removes the railing outside the ship"
           );
            var railingToggle = new BoolCheckBoxConfigItem(deleteRailing, requiresRestart: false);
            LethalConfigManager.AddConfigItem(railingToggle);

            deleteThrusterTube = cfg.Bind(
               "General",
               "Outside: Back Right Thruster Tube",
               false,
               "Removes the thruster tube in the back right. NOTE: Also deletes back right thruster"
           );
            var thrusterTubeToggle = new BoolCheckBoxConfigItem(deleteThrusterTube, requiresRestart: false);
            LethalConfigManager.AddConfigItem(thrusterTubeToggle);

            deleteThrusters = cfg.Bind(
               "General",
               "Outside: All Thrusters",
               false,
               "Removes all thrusters."
           );
            var thrustersToggle = new BoolCheckBoxConfigItem(deleteThrusters, requiresRestart: false);
            LethalConfigManager.AddConfigItem(thrustersToggle);
        }
    }
}