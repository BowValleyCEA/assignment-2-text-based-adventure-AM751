using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1402_a2_starter

{
    [Serializable] //the [Serializable] attribute will be needed if you ever want to save this info

    public class Room
    {
     
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public string thePath { get; set; }
        public string North { get; set; }// Direction to the Dining Room.
        public string South { get; set; }// Direction to the Living Room.
        public string East   { get; set; }// Direction to the Kitchen.
        public string West { get; set; }// Direction to the Store room.
        public string NorthEast { get; set; }// the Exit.
        public string Gate { get; set; }//the final part of the game.
        public bool IsExit { get; set; }//for the game end process.

      

        
    }
    
}
