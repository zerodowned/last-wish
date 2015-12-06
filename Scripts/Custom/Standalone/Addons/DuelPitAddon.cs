/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AG_DuelPitAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_DuelPitAddonDeed();
			}
		}

		[ Constructable ]
		public AG_DuelPitAddon()
		{
			AddComponent( new AddonComponent( 1315 ), -2, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), -2, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 7424 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, -3, 0 );
			AddComponent( new AddonComponent( 7423 ), 2, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 7426 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 7425 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 7434 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 7432 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 7433 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, -3, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, 4, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 7418 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), 0, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 7441 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 7440 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), 4, -5, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 7427 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 7428 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, -4, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), -3, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 7442 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 7421 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, -2, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, -2, 0 );
			AddComponent( new AddonComponent( 2057 ), -2, 5, 0 );
			AddComponent( new AddonComponent( 2057 ), -3, 5, 0 );
			AddComponent( new AddonComponent( 2057 ), -4, 5, 0 );
			AddComponent( new AddonComponent( 2057 ), -5, 5, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 7416 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, 2, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, 3, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, 4, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 7411 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, -1, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, 0, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, -2, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, -2, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, 3, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, 1, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 7419 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 2057 ), 3, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, -4, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, -5, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, -4, 0 );
			AddComponent( new AddonComponent( 2057 ), 4, 5, 0 );
			AddComponent( new AddonComponent( 2057 ), 3, 5, 0 );
			AddComponent( new AddonComponent( 2057 ), 2, 5, 0 );
			AddComponent( new AddonComponent( 2057 ), 1, 5, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 7410 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 7409 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 7437 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 7422 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 7436 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), -4, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 7435 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), 1, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, -4, 0 );
			AddComponent( new AddonComponent( 1315 ), 2, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), 2, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 7430 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 7431 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, 1, 0 );
			AddComponent( new AddonComponent( 7414 ), -3, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, 2, 0 );
			AddComponent( new AddonComponent( 7413 ), -3, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), 4, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 1315 ), 3, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 7420 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, 0, 0 );
			AddComponent( new AddonComponent( 7415 ), -3, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, -3, 0 );
			AddComponent( new AddonComponent( 1 ), -3, -3, 0 );
			AddComponent( new AddonComponent( 1315 ), -3, -2, 0 );
			AddComponent( new AddonComponent( 7417 ), -3, -2, 0 );
			AddComponent( new AddonComponent( 1315 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 7412 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, -2, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, -2, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), -4, 1, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, 0, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, -3, 0 );
			AddComponent( new AddonComponent( 2033 ), 5, 2, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, 4, 0 );
			AddComponent( new AddonComponent( 1315 ), -5, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), -5, -5, 0 );
			AddComponent( new AddonComponent( 2033 ), -5, -5, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 7429 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 1315 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 7439 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 7438 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 1315 ), -1, -5, 0 );
			AddComponent( new AddonComponent( 2057 ), -1, -5, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, -4, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -5, -5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -4, -5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -3, -5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -2, -5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, -5, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -5, 4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, 4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, -3, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, -2, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, -1, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, 0, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, 1, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, 2, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, 3, 0 );
			ac = new AddonComponent( 2033 );
			ac.Hue = 38;
			AddComponent( ac, -5, 4, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -5, 5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -4, 5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -3, 5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, -4, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 1, -5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 2, -5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 3, -5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 4, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, -5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, -4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, 2, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 2, 5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 3, 5, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 4, 5, 0 );
			ac = new AddonComponent( 1315 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 2057 );
			ac.Hue = 38;
			AddComponent( ac, 1, 5, 0 );

		}

		public AG_DuelPitAddon( Serial serial ) : base( serial )
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

	public class AG_DuelPitAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_DuelPitAddon();
			}
		}

		[Constructable]
		public AG_DuelPitAddonDeed()
		{
			Name = "AG_DuelPit";
		}

		public AG_DuelPitAddonDeed( Serial serial ) : base( serial )
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