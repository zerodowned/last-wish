using System;
using Server.Network;

namespace Server.Items
{
    [Flipable( 0x2A5D, 0x2A61 )]
	public class DisturbingPortraitComponent : AddonComponent
	{
		public override int LabelNumber { get { return 1074479; } } // Disturbing portrait

		private Timer m_Timer;

		public DisturbingPortraitComponent() : base( 0x2A5D )
		{
			m_Timer = Timer.DelayCall( TimeSpan.FromMinutes( 3 ), TimeSpan.FromMinutes( 3 ), new TimerCallback( Change ) );
		}

		public DisturbingPortraitComponent( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( Utility.InRange( Location, from.Location, 2 ) )
				Effects.PlaySound( Location, Map, Utility.RandomMinMax( 0x567, 0x568 ) );
			else
				from.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
		}

		public override void OnAfterDelete()
		{
			base.OnAfterDelete();

			if ( m_Timer != null && m_Timer.Running )
				m_Timer.Stop();
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

			m_Timer = Timer.DelayCall( TimeSpan.FromMinutes( 3 ), TimeSpan.FromMinutes( 3 ), new TimerCallback( Change ) );
		}

		private void Change()
		{
			if ( ItemID < 0x2A61 )
				ItemID = Utility.RandomMinMax( 0x2A5D, 0x2A60 );
			else
				ItemID = Utility.RandomMinMax( 0x2A61, 0x2A64 );
		}
	}

	public class DisturbingPortraitAddon : BaseAddon
	{
		public override BaseAddonDeed Deed { get { return new DisturbingPortraitDeed(); } }

		[Constructable]
		public DisturbingPortraitAddon() : base()
		{
			AddComponent( new DisturbingPortraitComponent(), 0, 0, 0 );
		}

		public DisturbingPortraitAddon( Serial serial ) : base( serial )
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

	public class DisturbingPortraitDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new DisturbingPortraitAddon(); } }
		public override int LabelNumber { get { return 1074479; } } // Disturbing portrait

		[Constructable]
		public DisturbingPortraitDeed() : base()
		{
			LootType = LootType.Blessed;
		}

		public DisturbingPortraitDeed( Serial serial ) : base( serial )
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
