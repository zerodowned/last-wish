/////////////////////////////////////////////////
// Christmas Tree for Town Center  w/o Gifts   //
// by Dracana                                  //
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
/////////////////////////////////////////////////

using Server;
using Server.Items;

namespace Server.Items
{
	public class TownCenterChristmasTreeNGAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TownCenterChristmasTreeNGAddonDeed();
			}
		}

		[ Constructable ]
		public TownCenterChristmasTreeNGAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 1, -2, 20 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, -1, 16 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, 1, 0, 29 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 1, 0, 41 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 1, 0, 69 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 0, 49 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, 2, -1, 48 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, -1, 0, 29 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, 0, 0, 29 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, 1, -2, 2 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, 0, 0, 45 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, -2, -2, 30 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, 0, -1, 32 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, -1, 0, 32 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, 0, -1, 21 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, -1, 0, 21 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, 0, -2, 3 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, -2, 0, 3 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, -1, -1, 3 );
			ac = new AddonComponent( 3296 );
			AddComponent( ac, -1, -1, 3 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, 2, 0, 61 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 1, -1, 43 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 0, 2, 65 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 1, 1, 88 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 1, 1, 38 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, -2, 1, 22 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 0, 2, 55 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, -1, 2, 23 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, 1, 1, 58 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 1, 43 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, 1, 69 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 1, 29 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, 2, 28 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 1, 65 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 2, 56 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, -2, 1, 3 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, 2, 1, 75 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 1, 1, 38 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 0, 2, 74 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 0, 1, 38 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, -1, 1, 57 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 0, 1, 22 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, -2, 2, 22 );
			ac = new AddonComponent( 4046 );
			AddComponent( ac, 1, 2, 23 );
			ac = new AddonComponent( 4050 );
			AddComponent( ac, 2, 1, 53 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, 1, 31 );

		}

		public TownCenterChristmasTreeNGAddon( Serial serial ) : base( serial )
		{
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

	public class TownCenterChristmasTreeNGAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TownCenterChristmasTreeNGAddon();
			}
		}

		[Constructable]
		public TownCenterChristmasTreeNGAddonDeed()
		{
			Name = "Town Center Christmas Tree";
		}

		public TownCenterChristmasTreeNGAddonDeed( Serial serial ) : base( serial )
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