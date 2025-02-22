namespace Server.Items
{
    public class TrueRadiantScimitar : RadiantScimitar
	{
		public override int LabelNumber{ get{ return 1073541; } } // true radiant scimitar

		[Constructable]
		public TrueRadiantScimitar()
		{
			Attributes.NightSight = 1;
		}

		public TrueRadiantScimitar( Serial serial ) : base( serial )
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
