/*
File: Stats.cs
Description: StatsCommons.cs defines all the different starts in the game.
Purpsoe: This file makes it easy to calculate attacks since all the stats
will be stored in the same object
*/

namespace Client.cmdline_rpg.common
{
    public class Stats
    {
        int attack;
        int defense;
        int dexterity;
        int magic;
        int faith;
        int endurance;
        int mining;
        int botany;
        int fishing;
        int farming;
        int hunting;

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

        // Getters and setters
        public int getAttack() {
            return this.attack;
        }

        public int getDefense() {
            return this.defense;
        }

        public int getDexterity() {
            return this.dexterity;
        }

        public int getMagic() {
            return this.magic;
        }

        public int getFaith() {
            return this.faith;
        }

        public int getEndurance() {
            return this.endurance;
        }

        public int getMining() {
            return this.mining;
        }

        public int getBotany() {
            return this.botany;
        }

        public int getFishing() {
            return this.fishing;
        }

        public int getFarming() {
            return this.farming;
        }

        public int getHunting() {
            return this.hunting;
        }

        public void setAttack(int val) {
            this.attack = val;
        }

        public void setDefense(int val) {
            this.defense = val;
        }

        public void setDexterity(int val) {
            this.dexterity = val;
        }

        public void setMagic(int val) {
            this.magic = val;
        }

        public void setFaith(int val) {
            this.faith = val;
        }

        public void setEndurance(int val) {
            this.endurance = val;
        }

        public void setMining(int val) {
            this.mining = val;
        }

        public void setBotany(int val) {
            this.botany = val;
        }

        public void setFishing(int val) {
            this.fishing = val;
        }

        public void setFarming(int val) {
            this.farming = val;
        }

        public void setHunting(int val) {
            this.hunting = val;
        }
    }
}