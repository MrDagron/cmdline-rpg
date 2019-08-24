/*
    File: PlayerCommons.cs
    Description: This file contains all the different variables all player objects will have in common such as name, 
    hp, inventory, etc.
    Purpose: This class allows other objects to inherit its property and define them as needed
 */

namespace cmdline_rpg.common
{
    public abstract class PlayerCommons
    {
        string name; // player name
        int hp; // player hit points

        /* 
            Object types to add here later when implemented: 
                1. Inventory object
                2. Equipment object
                3. Abilties/Spells object
                4. Stats object
        */

        // Constructor
        public PlayerCommons(string playerName, int hp) {
            this.name = playerName;
            this.hp = hp;
        }

        // Attack command that will be determine a lot of other things by the Player object implemented later
        public abstract void attack();
        public abstract void defend();
        public abstract void use(); // Will probably have an argument eventually, but no arguments for now

        // Getters and setters
        public string getName() {
            return this.name;
        }

        public int getHp() {
            return hp;
        }

        public void setName(string name) {
            this.name = name;
        }

        public void setHp(int hp) {
            this.hp = hp;
        }
    }
}