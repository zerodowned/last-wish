namespace Server.Items
{
    public class HealersTouch : LeatherGloves
	{
		public override int LabelNumber{ get{ return 1077684; } } // Healer's Touch

		public override int BasePhysicalResistance{ get{ return 6; } }
		public override int BaseFireResistance{ get{ return 6; } }
		public override int BaseColdResistance{ get{ return 5; } }
		public override int BasePoisonResistance{ get{ return 5; } }
		public override int BaseEnergyResistance{ get{ return 5; } }

		[Constructable]
		public HealersTouch()
		{
			LootType = LootType.Blessed;

			Attributes.BonusStam = 3;
			Attributes.ReflectPhysical = 5;
		}

		public HealersTouch( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}
