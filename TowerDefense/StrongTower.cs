using System;
namespace TowerDefense
{
    public class StrongTower : Tower
    {
        protected override int Power { get; } = 2;

        public StrongTower(MapLocation location) : base(location)
        {
        }
    }
}
