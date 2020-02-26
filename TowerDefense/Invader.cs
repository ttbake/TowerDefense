﻿using System;
namespace TowerDefense
{
    public class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public virtual int Health { get; private set; } = 2;

        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}
