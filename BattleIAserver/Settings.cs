﻿using System;

namespace BattleIAserver
{
    public class Settings
    {
        public int ServerPort = 4626;
        //le port qui sera utilisé par le serveur
        public int DelayBetweenEachBotTurn = 100;
        //le délai en secondes entre chaque tour des bots
        public UInt16 MapWidth = 30;
        public UInt16 MapHeight = 24;
        public UInt16 MapPercentWall = 4;
        public UInt16 MapPercentEnergy = 5;
        //les tailles de la map

        public UInt16 MaxDelaySecondByTurn = 5;
        //le délai max par tour

        public UInt16 EnergyPodFrom = 1;
        public UInt16 EnergyPodTo = 50;
        public UInt16 EnergyPodLessEvery = 5;
        public UInt16 EnergyPodLessValue = 1;
        public UInt16 EnergyPodMin = 10;
        //valeurs energie pods

        public bool EndlessMode = true;
        public bool autoRespawn = true;
        //respawn automatique ou non
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public UInt16 EnergyPodMax;

        public UInt16 EnergyCloakCostMultiplier = 2;
        public UInt16 EnergyLostByCloak = 5;
        //cout en energie pour cacher

        public UInt16 EnergyStart = 100;
        public UInt16 EnergyLostByTurn = 1;
        public UInt16 EnergyLostByShield = 1;
        public UInt16 EnergyLostByMove = 1;
        public UInt16 EnergyLostShot = 2;
        public UInt16 EnergyLostContactWall = 5;
        public UInt16 EnergyLostContactEnemy = 30;
        //couts en energie

        public UInt16 PointByTurn = 1;
        public UInt16 PointByEnergyFound = 8;
        public UInt16 PointByEnnemyTouch = 80;
        public UInt16 PointByEnnemyKill = 200;
        //points gagnes par action
        public String MapName = "map_1.txt";
        //map utilisée

    }
}
