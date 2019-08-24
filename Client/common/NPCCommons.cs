/*
    File: NPCCommons.cs
    Description: This file contains all the different variables all NPCs will have in common;
    it also includes some methods to be implemented. 
    Purpose: This class allows other objects to inherit its property and define them as needed
 */

namespace cmdline_rpg.Common
{
    public abstract class NPCCommons
    {
        private string name; // NPC Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int hp; // NPC Health
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
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
    }
}