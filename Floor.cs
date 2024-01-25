using System.Drawing;

namespace CodeAlong5
{
    internal class Floor
    {
        private List<Room> rooms = new List<Room>();

        //Checking if kitchen or bathroom exists in the list when the user tries to input the same
        //and lets the user input only one kitchen, and one bathroom on one floor
        public bool CheckIfNotExists(Room room)
        {
            if (room.Type.ToLower() != "kitchen" && room.Type.ToLower() != "bathroom")
            {
                return true;
            }
            else if ((room.Type.ToLower() == "kitchen" || room.Type.ToLower() == "bathroom") && !rooms.Any(r => r.Type.ToLower() == room.Type.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddRoom(Room room)
        {
            if (CheckIfNotExists(room))
            {
                rooms.Add(room);
            }

        }

        public List<Room> GetRooms()
        {
            return rooms;
        }
    }        
}
