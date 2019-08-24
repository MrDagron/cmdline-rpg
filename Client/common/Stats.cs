/*
File: Stats.cs
Description: StatsCommons.cs defines all the different starts in the game.
Purpsoe: This file makes it easy to calculate attacks since all the stats
will be stored in the same object
*/

namespace cmdline_rpg.common
{
    public class Stats
    {
        private int attack;
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        private int defense;
        public int Defense 
        {
            get { return defense; }
            set { defense = value; }
        }
        private int dexterity;
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        private int magic;
        public int Magic
        {
            get { return magic; }
            set { magic = value; }
        }
        private int faith;
        public int Faith
        {
            get { return faith; }
            set { faith = value; }
        }
        private int endurance;
        public int Endurance
        {
            get { return endurance; }
            set { endurance = value; }
        }
        private int mining;
        public int Mining
        {
            get { return mining; }
            set { mining = value; }
        }
        private int botany;
        public int Botany
        {
            get { return botany; }
            set { botany = value; }
        }
        private int fishing;
        public int Fishing
        {
            get { return fishing; }
            set { fishing = value; }
        }
        private int farming;
        public int Farming
        {
            get { return farming; }
            set { farming = value; }
        }
        private int hunting;
        public int Hunting
        {
            get { return hunting; }
            set { hunting = value; }
        }
        // Constructor
        public Stats() {
            this.attack = 10;
            this.defense = 10;
            this.dexterity = 10;
            this.magic = 10;
            this.faith = 10;
            this.endurance = 10;
            this.mining = 10;
            this.botany = 10;
            this.fishing = 10;
            this.farming  = 10;
            this.hunting = 10;
        }
    }
}