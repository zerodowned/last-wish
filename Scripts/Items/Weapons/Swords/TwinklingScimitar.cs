namespace Server.Items
{
    public class TwinklingScimitar : RadiantScimitar
	{
		public override int LabelNumber{ get{ return 1073544; } } // twinkling scimitar

		[Constructable]
		public TwinklingScimitar()
		{
			Attributes.DefendChance = 6;
		}

		public TwinklingScimitar( Serial serial ) : base( serial )
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
