/*
    File: NPCCommons.cs
    Description: This file contains all the different variables all NPCs will have in common;
    it also includes some methods to be implemented. 
    Purpose: This class allows other objects to inherit its property and define them as needed
 */

namespace cmdline_rpg.common
{
    public abstract class NPCCommons
    {
        string name; // NPC Name
        int hp; // NPC Health

        /* 
            Object types to add here later when implemented: 
                1. Equipment object
                2. Abilties/Spells object
                3. Loot table
                4. Dialogue
                5. Stats
        */

        // Constructor
        public NPCCommons(string npcName, int hp) {
            this.name = npcName;
            this.hp = hp;
        }

        /* 
            More constructors will be added in the future to account for
            the different object types introduced to this file.
        */

        public abstract void attack();
        public abstract void defend();
        public abstract void interact();

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