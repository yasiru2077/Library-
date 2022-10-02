using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //If I were to call the Member class from another namespace, that would require the class to be public
    public class Member
	{
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; }

        public Member(string name)
        {
            Id = nextId++;
            Name = name;
        }
    }
}
