using System;
namespace TowerDefense
{
    public class DefenseException : System.Exception
    {
        public DefenseException()
        {
        }

        public DefenseException(string message) : base(message)
        {
        }
    }

    public class OutOfBoundsException : DefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
