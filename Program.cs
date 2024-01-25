namespace CodeAlong5
{
    internal class Program
    {
        static void Main()
        {
            var house = new House();
            var floor = new Floor();

            ///////////////////////////////////////////////////////////////////////
            Console.WriteLine("Add rooms to the house! A floor must contain 5 rooms. Enter 'Enter' to finish.");
            
            int f = 0;


            while (true)
            {
                string UserInput;

                for (int i = 1;  i <= 5; i++) 
                {
                    UserInput = Console.ReadLine()!;
                    floor.AddRoom(new Room(UserInput));
                }
                f++;
                Console.WriteLine($"{f}. Floor ----------------");
                house.CreateFloor(floor);

                Console.WriteLine("Continue?");

                UserInput = Console.ReadLine()!;
                if (string.IsNullOrEmpty(UserInput)) break;
            }

            
            ///////////////////////////////////////////////////////////////////////


            Console.WriteLine("Huset består av følgende rom:");
            foreach (var room in house.GetAllRooms())
            {   
                
                Console.WriteLine(room.Type);
            }

            int RoomCount = house.GetAllRooms().Count;
            if(RoomCount % 5 != 0) Console.WriteLine("-------The house is not finshed!---------------");
        }
    }
}


/*Om du har klasse house burde den ha List<Floor> (Et hus har flere etasjer) Hus burde også da inneholde en metode "CreateFloor() eller CreateFloors(int numberOfFloors) som bare lager og legger til Floor objekter i listen. Objektet Floor har en liste av Rom (En etasje har flere rom). Floor burde da også ha en metode AddRoomToFloor(Room roomToAdd). IF check på om roomet allerede eksisterer (rom/bad) kan enten ligge i add room to floor eller være en egen metode i Floor objektet ex public bool CheckIfExists(Room room). I House klassen kan du ha alle menyene - først lage etasjer, så løkke gjennom etasjene og legge til rom i disse. Så kan House ha en metode Print() som løkker igjennom alle etasjene og printer ut hvilke rom de inneholder feks*/