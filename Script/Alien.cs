
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace Aaaa.Anjay { 

    public struct Alien : IShootable, Ipersitable
    {
        public int point
        {
            get; 
            set;
        }
        public int HP { 
            get; 
            set; 
        }
        public bool Status
        {
            get; set;
        }

        public Alien(int Point, int hp, bool status) : this()
        {
            this.point = Point;
            this.HP = hp;
            this.Status = status;
        }

        public Alien(int Point) : this(Point, 100, true)
        {

        }
        public void Fire()
        {
            Debug.Log("Alien Fire");
        }
        public void Save()
        {
            Debug.Log("Alien Saved");
        }
    }
}