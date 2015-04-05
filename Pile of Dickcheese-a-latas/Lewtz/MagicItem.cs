﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rds;

namespace Lewtz
{
    class MagicItem : Item
    {
        private string ItemType = "Some Magic Type Done Broke!";
        private string ItemName = "Magic Name is Broken!";
        private double Cost = 0;
        private int totalBonus = 0;


        public MagicItem(string type, string name, double cost, int bonus)
        {
            totalBonus = bonus;
            ItemType = type;
            ItemName = name;
            Cost = cost;
        }
        public MagicItem(string type)
        {
            totalBonus = 0;
            ItemType = type;
            Cost = 0;
        }

        public override double GetCost()
        {
            return Cost;
        }
        public override string GetItemType()
        {
            return ItemType;
        }

        public override string ToString()
        {
            return ItemName;
        }
        public int GetBonus()
        {
            return totalBonus;
        }
        public void SetBonus(int bonus)
        {
            totalBonus = bonus;
        }

        public override IRDSObject rdsCreateInstance()
        {
            return new MagicItem(ItemType,ItemName,Cost,totalBonus);
        }
    }
}
