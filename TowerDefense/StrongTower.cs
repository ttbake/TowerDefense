using System;
namespace TowerDefense
{
    public class StrongTower : Tower
    {
        private readonly MapLocation _location;

        public StrongTower(MapLocation location) : base(location)
        {
            _location = location;
            Power = 2;
        }
    }
}
