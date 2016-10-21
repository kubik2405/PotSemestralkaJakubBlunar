﻿using System;
using System.Xml.Serialization;

namespace Core
{
    [XmlRoot("GameItem")]
    public class GameItem : GameItemBase
    {
        public string TextLook { get; set; }
       
        public string TextUse { get; set; }

        public override GameObjectType Type => GameObjectType.UnknownItem;

        public GameItem() { }

        public GameItem(string name,string textLook, string textUse)
        {
            Name = name;
            TextLook = textLook;
            TextUse = textUse;
        }

        public override void Look(Player p)
        {
            Console.WriteLine(TextLook);
        }

        public override void Take()
        {
            
        }

        public override void Use(Player p)
        {
            Console.WriteLine(TextUse);
        }

     
    }
}
