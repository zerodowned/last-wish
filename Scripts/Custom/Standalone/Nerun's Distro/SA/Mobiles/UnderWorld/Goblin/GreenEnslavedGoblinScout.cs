using Server.Items;

namespace Server.Mobiles
{
    [CorpseName( "a goblin corpse" )]
	public class EnslavedGoblinScout : BaseCreature
	{
		[Constructable]
		public EnslavedGoblinScout() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "an enslaved goblin scout";
			Body = 723;
			BaseSoundID = 0x45A;

			SetStr( 336 );
			SetDex( 75 );
			SetInt( 138 );

			SetHits( 174 );
			SetStam( 75 );
			SetMana( 138 );

			SetDamage( 5, 7 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 41 );
			SetResistance( ResistanceType.Fire, 30 );
			SetResistance( ResistanceType.Cold, 30 );
			SetResistance( ResistanceType.Poison, 20 );
			SetResistance( ResistanceType.Energy, 14 );

			SetSkill( SkillName.MagicResist, 98.6 );
			SetSkill( SkillName.Tactics, 84.1 );
			SetSkill( SkillName.Anatomy, 86.2 );
			SetSkill( SkillName.Wrestling, 109.1 );

			Fame = 1500;
			Karma = -1500;

			VirtualArmor = 28;

			// loot 60 gold, magic item, gem, bola ball, liquar,gob blood
			switch ( Utility.Random( 20 ) )
			{
				case 0: PackItem( new Scimitar() ); break;
				case 1: PackItem( new Katana() ); break;
				case 2: PackItem( new WarMace() ); break;
				case 3: PackItem( new WarHammer() ); break;
				case 4: PackItem( new Kryss() ); break;
				case 5: PackItem( new Pitchfork() ); break;
			}

			PackItem( new ThighBoots() );

			switch ( Utility.Random( 3 ) )
			{
				case 0: PackItem( new Ribs() ); break;
				case 1: PackItem( new Shaft() ); break;
				case 2: PackItem( new Candle() ); break;
			}

			if ( 0.2 > Utility.RandomDouble() )
				PackItem( new BolaBall() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.SuperBoss, 1 );
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override int TreasureMapLevel{ get{ return 1; } }
		public override int Meat{ get{ return 1; } }

		public override OppositionGroup OppositionGroup
		{
			get{ return OppositionGroup.SavagesAndOrcs; }
		}

		//public override bool IsEnemy( Mobile m )
		//{
		//	if ( m.Player && m.FindItemOnLayer( Layer.Helm ) is OrcishKinMask )
		//		return false;

		//	return base.IsEnemy( m );
		//}

		//public override void AggressiveAction( Mobile aggressor, bool criminal )
		//{
			//base.AggressiveAction( aggressor, criminal );

			//Item item = aggressor.FindItemOnLayer( Layer.Helm );

			//if ( item is OrcishKinMask )
			//{
			//	AOS.Damage( aggressor, 50, 0, 100, 0, 0, 0 );
			//	item.Delete();
			//	aggressor.FixedParticles( 0x36BD, 20, 10, 5044, EffectLayer.Head );
			//	aggressor.PlaySound( 0x307 );
			//}
		//}

		public EnslavedGoblinScout( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
