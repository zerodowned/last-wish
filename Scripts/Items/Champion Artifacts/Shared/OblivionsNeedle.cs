namespace Server.Items
{
    public class OblivionsNeedle : Dagger
	{
		public override int LabelNumber{ get{ return 1094916; } } // Oblivion's Needle [Replica]

		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }

		public override bool CanFortify{ get{ return false; } }

		[Constructable]
		public OblivionsNeedle()
		{
			Attributes.BonusStam = 20;
			Attributes.AttackChance = 20;
			Attributes.DefendChance = -20;
			Attributes.WeaponDamage = 40;

			WeaponAttributes.HitLeechStam = 50;
		}

		public OblivionsNeedle( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
