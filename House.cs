namespace CodeAlong5
{
    internal class House
    {
        private List<Floor> floors = new List<Floor>();

        public void CreateFloor(Floor floor)
        {
            floors.Add(floor);
        }

        public List<Room> GetAllRooms()
        {
            var allRooms = new List<Room>();
            foreach (var floor in floors)
            {
                allRooms.AddRange(floor.GetRooms());
            }
            return allRooms;
        }
    }
}
