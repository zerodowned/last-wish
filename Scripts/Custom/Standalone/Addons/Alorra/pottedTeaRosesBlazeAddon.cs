
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class pottedTeaRosesBlazeAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new pottedTeaRosesBlazeAddonDeed();
			}
		}

		[ Constructable ]
		public pottedTeaRosesBlazeAddon()
		{



			AddComplexComponent( (BaseAddon) this, 4551, 0, 0, 0, 1150, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3332, 0, 0, 3, 0, -1, "leaves", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3348, 0, 0, 7, 1161, -1, "Tea roses", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3345, 0, 0, 4, 1161, -1, "Tea roses", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3343, 0, 0, 4, 1161, -1, "Tea roses", 1);// 5

		}

		public pottedTeaRosesBlazeAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class pottedTeaRosesBlazeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new pottedTeaRosesBlazeAddon();
			}
		}

		[Constructable]
		public pottedTeaRosesBlazeAddonDeed()
		{
			Name = "pottedTeaRosesBlaze";
		}

		public pottedTeaRosesBlazeAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}