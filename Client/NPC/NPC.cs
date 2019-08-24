/*
File: NPC.cs
Description: This file contains data related to NPCs in
the game. It inherits from the abstract class NPCCommons.
Purpose: This class serves as a base for all differnt types of NPCs. 
Future NPC derivative classes can inherit from this class as necessary.
*/

using Client.Common;

namespace Client.NPC
{
    public class NPC : NPCCommons
    {
        public NPC(string npcName, int hp) : base(npcName, hp) 
        {

        }

        public override void attack()
        {

        }

        public override void defend() 
        {

        }

        public override void interact()
        {

        }
    }
}