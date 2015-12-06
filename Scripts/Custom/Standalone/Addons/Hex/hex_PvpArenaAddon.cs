////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class hex_PvpArenaAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4650, 0, -3, 1}, {4650, 0, 2, 1}, {4651, -2, -1, 1}// 1	2	3	
			, {4652, 2, -1, 2}, {4653, -3, -4, 1}, {6921, 2, -3, 0}// 4	5	6	
			, {6930, -2, 1, 0}, {6933, 1, 0, 0}, {6939, 2, 2, 0}// 7	8	9	
			, {7570, 2, -4, 0}, {7571, 3, -4, 0}, {7572, -3, -2, 0}// 10	11	12	
			, {7573, -3, -4, 0}, {7574, -3, 2, 0}, {6936, 0, -1, 0}// 13	14	15	
			, {2860, -5, -3, 22}, {2860, -5, -2, 22}, {2860, -5, -1, 22}// 16	17	18	
			, {2860, -5, 0, 22}, {2860, -5, 1, 22}, {2860, -5, 2, 22}// 19	20	21	
			, {2860, -5, 3, 22}, {2860, -5, 4, 22}, {2860, 6, -3, 22}// 22	23	24	
			, {2860, 6, -2, 22}, {2860, 6, -1, 22}, {2860, 6, 0, 22}// 25	26	27	
			, {2860, 6, 1, 22}, {2860, 6, 2, 22}, {2860, 6, 3, 22}// 28	29	30	
			, {2860, 6, 4, 22}, {1313, -6, -4, 22}, {1308, -6, -3, 22}// 31	40	41	
			, {1305, -6, -2, 22}, {1309, -6, -1, 22}, {1309, -6, -6, 22}// 42	43	44	
			, {1308, -6, -5, 22}, {8669, -6, -7, 22}, {8671, -7, -6, 22}// 45	46	47	
			, {8671, -7, -5, 22}, {8672, -7, -4, 22}, {8672, -7, -3, 22}// 48	49	50	
			, {8671, -7, -2, 22}, {8671, -7, -1, 22}, {768, -7, -7, 22}// 51	52	53	
			, {1316, -6, 0, 22}, {1305, -6, 1, 22}, {1309, -6, 2, 22}// 54	55	56	
			, {1305, -6, 3, 22}, {1310, -6, 4, 22}, {8671, -7, 0, 22}// 57	58	59	
			, {8672, -7, 1, 22}, {8671, -7, 2, 22}, {8672, -7, 3, 22}// 60	61	62	
			, {8671, -7, 4, 22}, {8679, -4, -4, 0}, {8679, -4, -3, 0}// 63	64	65	
			, {8679, -4, -2, 0}, {8680, -4, -1, 0}, {8678, -3, -5, 0}// 66	67	68	
			, {8678, -2, -5, 0}, {8678, -1, -5, 0}, {8678, 0, -5, 0}// 69	70	71	
			, {8677, 1, -5, 0}, {8678, 2, -5, 0}, {8677, 3, -5, 0}// 72	73	74	
			, {8678, 4, -5, 0}, {8678, 5, -5, 0}, {8679, 5, -4, 0}// 75	76	77	
			, {8679, 5, -3, 0}, {8679, 5, -2, 0}, {8680, 5, -1, 0}// 78	79	80	
			, {1306, -4, -4, 22}, {1313, -4, -3, 22}, {1310, -4, -2, 22}// 81	82	83	
			, {1313, -4, -1, 22}, {1314, -5, -4, 22}, {1310, -5, -3, 22}// 84	85	86	
			, {1305, -5, -2, 22}, {1307, -5, -1, 22}, {1310, -5, -6, 22}// 87	88	89	
			, {1315, -5, -5, 22}, {1310, -4, -6, 22}, {1308, -4, -5, 22}// 90	91	92	
			, {1315, -3, -6, 22}, {1307, -3, -5, 22}, {1309, -2, -6, 22}// 93	94	95	
			, {1307, -2, -5, 22}, {1314, -1, -6, 22}, {1309, -1, -5, 22}// 96	97	98	
			, {1316, 0, -6, 22}, {1309, 0, -5, 22}, {1307, 1, -6, 22}// 99	100	101	
			, {1309, 1, -5, 22}, {1316, 2, -6, 22}, {1316, 2, -5, 22}// 102	103	104	
			, {1305, 3, -6, 22}, {1308, 3, -5, 22}, {1305, 4, -6, 22}// 105	106	107	
			, {1308, 4, -5, 22}, {1307, 5, -6, 22}, {1305, 5, -5, 22}// 108	109	110	
			, {1306, 6, -6, 22}, {1314, 6, -5, 22}, {1305, 6, -4, 22}// 111	112	113	
			, {1308, 6, -3, 22}, {1309, 6, -2, 22}, {1312, 6, -1, 22}// 114	115	116	
			, {1310, 7, -6, 22}, {1309, 7, -5, 22}, {1308, 7, -4, 22}// 117	118	119	
			, {1305, 7, -3, 22}, {1306, 7, -2, 22}, {1311, 7, -1, 22}// 120	121	122	
			, {1315, 8, -6, 22}, {1311, 8, -5, 22}, {1310, 8, -4, 22}// 123	124	125	
			, {1311, 8, -3, 22}, {1312, 8, -2, 22}, {1315, 8, -1, 22}// 126	127	128	
			, {1316, 4, -4, 0}, {1313, 4, -3, 0}, {1315, 4, -2, 0}// 129	130	131	
			, {1314, 4, -1, 0}, {1314, 5, -4, 0}, {1314, 5, -3, 0}// 132	133	134	
			, {1316, 5, -2, 0}, {1315, 5, -1, 0}, {8672, 8, -6, 22}// 135	136	137	
			, {8671, 8, -5, 22}, {8671, 8, -4, 22}, {8671, 8, -3, 22}// 138	139	140	
			, {8672, 8, -2, 22}, {8672, 8, -1, 22}, {8669, -5, -7, 22}// 141	142	143	
			, {8669, -4, -7, 22}, {8669, -3, -7, 22}, {8669, -2, -7, 22}// 144	145	146	
			, {8669, -1, -7, 22}, {8669, 0, -7, 22}, {8670, 1, -7, 22}// 147	148	149	
			, {8669, 2, -7, 22}, {8669, 3, -7, 22}, {8669, 4, -7, 22}// 150	151	152	
			, {8670, 5, -7, 22}, {8670, 6, -7, 22}, {8670, 7, -7, 22}// 153	154	155	
			, {8670, 8, -7, 22}, {2213, 0, -4, 0}, {2213, 1, -4, 0}// 156	157	158	
			, {8671, -4, -4, 22}, {8671, -4, -3, 22}, {8671, -4, -2, 22}// 159	160	161	
			, {8671, -4, -1, 22}, {8669, -3, -5, 22}, {8669, -2, -5, 22}// 162	163	164	
			, {8669, -1, -5, 22}, {8669, 3, -5, 22}, {8669, 4, -5, 22}// 165	166	167	
			, {8669, 5, -5, 22}, {8671, 5, -4, 22}, {8671, 5, -3, 22}// 168	169	170	
			, {8671, 5, -2, 22}, {8671, 5, -1, 22}, {8670, 2, -5, 22}// 171	172	173	
			, {8680, -4, 0, 0}, {8680, -4, 1, 0}, {8680, -4, 2, 0}// 174	175	176	
			, {8680, -4, 3, 0}, {8680, -4, 4, 0}, {8679, 5, 0, 0}// 177	178	179	
			, {8679, 5, 1, 0}, {8679, 5, 2, 0}, {8680, 5, 3, 0}// 180	181	182	
			, {8679, 5, 4, 0}, {1316, -4, 0, 22}, {1316, -4, 1, 22}// 183	184	185	
			, {1309, -4, 2, 22}, {1315, -4, 3, 22}, {1312, -4, 4, 22}// 186	187	188	
			, {1316, -5, 0, 22}, {1312, -5, 1, 22}, {1311, -5, 2, 22}// 189	190	191	
			, {1309, -5, 3, 22}, {1309, -5, 4, 22}, {1315, 6, 0, 22}// 192	193	194	
			, {1310, 6, 1, 22}, {1313, 6, 2, 22}, {1312, 6, 3, 22}// 195	196	197	
			, {1306, 6, 4, 22}, {1306, 7, 0, 22}, {1307, 7, 1, 22}// 198	199	200	
			, {1308, 7, 2, 22}, {1316, 7, 3, 22}, {1316, 7, 4, 22}// 201	202	203	
			, {1314, 8, 0, 22}, {1306, 8, 1, 22}, {1315, 8, 2, 22}// 204	205	206	
			, {1314, 8, 3, 22}, {1316, 8, 4, 22}, {1314, -3, 4, 0}// 207	208	209	
			, {1314, -2, 4, 0}, {1316, -1, 4, 0}, {1314, 0, 4, 0}// 210	211	212	
			, {1315, 1, 4, 0}, {1315, 2, 4, 0}, {1313, 3, 4, 0}// 213	214	215	
			, {1313, 4, 0, 0}, {1313, 4, 1, 0}, {1314, 4, 2, 0}// 216	217	218	
			, {1316, 4, 3, 0}, {1314, 4, 4, 0}, {1316, 5, 0, 0}// 219	220	221	
			, {1313, 5, 1, 0}, {1313, 5, 2, 0}, {1316, 5, 3, 0}// 222	223	224	
			, {1314, 5, 4, 0}, {8672, 8, 0, 22}, {8671, 8, 1, 22}// 225	226	227	
			, {8672, 8, 2, 22}, {8671, 8, 3, 22}, {8671, 8, 4, 22}// 228	229	230	
			, {8671, -4, 0, 22}, {8671, -4, 1, 22}, {8671, -4, 2, 22}// 231	232	233	
			, {8671, -4, 3, 22}, {8671, -4, 4, 22}, {8671, 5, 0, 22}// 234	235	236	
			, {8671, 5, 1, 22}, {8671, 5, 2, 22}, {8671, 5, 3, 22}// 237	238	239	
			, {8671, 5, 4, 22}, {12788, -3, -4, 0}, {12791, -3, -3, 0}// 240	241	242	
			, {12789, -3, -2, 0}, {12789, -3, -1, 0}, {12791, -3, 0, 0}// 243	244	245	
			, {12790, -3, 1, 0}, {12789, -3, 2, 0}, {12789, -3, 3, 0}// 246	247	248	
			, {12791, -2, -4, 0}, {12791, -2, -3, 0}, {12788, -2, -2, 0}// 249	250	251	
			, {12789, -2, -1, 0}, {12790, -2, 0, 0}, {12790, -2, 1, 0}// 252	253	254	
			, {12789, -2, 2, 0}, {12791, -2, 3, 0}, {12791, -1, -4, 0}// 255	256	257	
			, {12790, -1, -3, 0}, {12790, -1, -2, 0}, {12790, -1, -1, 0}// 258	259	260	
			, {12790, -1, 0, 0}, {12789, -1, 1, 0}, {12791, -1, 2, 0}// 261	262	263	
			, {12790, -1, 3, 0}, {12791, 0, -4, 0}, {12788, 0, -3, 0}// 264	265	266	
			, {12789, 0, -2, 0}, {12788, 0, -1, 0}, {12791, 0, 0, 0}// 267	268	269	
			, {12791, 0, 1, 0}, {12791, 0, 2, 0}, {12791, 0, 3, 0}// 270	271	272	
			, {12791, 1, -4, 0}, {12789, 1, -3, 0}, {12791, 1, -2, 0}// 273	274	275	
			, {12789, 1, -1, 0}, {12790, 1, 0, 0}, {12789, 1, 1, 0}// 276	277	278	
			, {12788, 1, 2, 0}, {12790, 1, 3, 0}, {12790, 2, -4, 0}// 279	280	281	
			, {12789, 2, -3, 0}, {12791, 2, -2, 0}, {12789, 2, -1, 0}// 282	283	284	
			, {12789, 2, 0, 0}, {12790, 2, 1, 0}, {12789, 2, 2, 0}// 285	286	287	
			, {12789, 2, 3, 0}, {12788, 3, -4, 0}, {12791, 3, -3, 0}// 288	289	290	
			, {12791, 3, -2, 0}, {12788, 3, -1, 0}, {12788, 3, 0, 0}// 291	292	293	
			, {12791, 3, 1, 0}, {12789, 3, 2, 0}, {12789, 3, 3, 0}// 294	295	296	
			, {1308, -6, 5, 22}, {1315, -6, 6, 22}, {1312, -6, 7, 22}// 301	302	303	
			, {8671, -7, 5, 22}, {8672, -7, 6, 22}, {8672, -7, 7, 22}// 304	305	306	
			, {8669, -6, 7, 22}, {8679, -4, 5, 0}, {8678, -3, 5, 0}// 307	308	309	
			, {8678, -2, 5, 0}, {8677, -1, 5, 0}, {8678, 0, 5, 0}// 310	311	312	
			, {8677, 1, 5, 0}, {8677, 2, 5, 0}, {8677, 3, 5, 0}// 313	314	315	
			, {8678, 4, 5, 0}, {8677, 5, 5, 0}, {8680, 5, 5, 0}// 316	317	318	
			, {1312, -4, 5, 22}, {1311, -5, 5, 22}, {1306, 6, 5, 22}// 319	320	321	
			, {1311, 7, 5, 22}, {1315, 8, 5, 22}, {1316, -5, 6, 22}// 322	323	324	
			, {1308, -5, 7, 22}, {1313, -4, 6, 22}, {1310, -4, 7, 22}// 325	326	327	
			, {1306, -3, 6, 22}, {1312, -3, 7, 22}, {1305, -2, 6, 22}// 328	329	330	
			, {1307, -2, 7, 22}, {1311, -1, 6, 22}, {1314, -1, 7, 22}// 331	332	333	
			, {1310, 0, 6, 22}, {1309, 0, 7, 22}, {1305, 1, 6, 22}// 334	335	336	
			, {1313, 1, 7, 22}, {1316, 2, 6, 22}, {1313, 2, 7, 22}// 337	338	339	
			, {1305, 3, 6, 22}, {1306, 3, 7, 22}, {1307, 4, 6, 22}// 340	341	342	
			, {1312, 4, 7, 22}, {1314, 5, 6, 22}, {1315, 5, 7, 22}// 343	344	345	
			, {1307, 6, 6, 22}, {1313, 6, 7, 22}, {1313, 7, 6, 22}// 346	347	348	
			, {1308, 7, 7, 22}, {1316, 8, 6, 22}, {1312, 8, 7, 22}// 349	350	351	
			, {1313, -3, 5, 0}, {1316, -2, 5, 0}, {1316, -1, 5, 0}// 352	353	354	
			, {1313, 0, 5, 0}, {1313, 1, 5, 0}, {1314, 2, 5, 0}// 355	356	357	
			, {1315, 3, 5, 0}, {1316, 4, 5, 0}, {1316, 5, 5, 0}// 358	359	360	
			, {8672, 8, 5, 22}, {8671, 8, 6, 22}, {8672, 8, 7, 22}// 361	362	363	
			, {8669, -5, 7, 22}, {8669, -4, 7, 22}, {8669, -3, 7, 22}// 364	365	366	
			, {8669, -2, 7, 22}, {8669, -1, 7, 22}, {8670, 0, 7, 22}// 367	368	369	
			, {8669, 1, 7, 22}, {8669, 2, 7, 22}, {8669, 3, 7, 22}// 370	371	372	
			, {8670, 4, 7, 22}, {8669, 5, 7, 22}, {8669, 6, 7, 22}// 373	374	375	
			, {8670, 7, 7, 22}, {8670, 8, 7, 22}, {8671, -4, 5, 22}// 376	377	378	
			, {8669, -3, 5, 22}, {8669, -2, 5, 22}, {8669, -1, 5, 22}// 379	380	381	
			, {8669, 0, 5, 22}, {8669, 1, 5, 22}, {8669, 2, 5, 22}// 382	383	384	
			, {8669, 3, 5, 22}, {8669, 4, 5, 22}, {8669, 5, 5, 22}// 385	386	387	
			, {8671, 5, 5, 22}// 388	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new hex_PvpArenaAddonDeed();
			}
		}

		[ Constructable ]
		public hex_PvpArenaAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2567, -3, 2, 13, 0, 0, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2567, -3, -3, 13, 0, 0, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2572, -1, -4, 13, 0, 0, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2572, 2, -4, 13, 0, 0, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 3633, -5, -4, 22, 0, 1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 3633, 6, -4, 22, 0, 1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 6571, 6, -4, 29, 0, 0, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 6571, -5, -4, 29, 0, 0, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 3633, 6, 5, 22, 0, 1, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 3633, -5, 5, 22, 0, 1, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 6571, 6, 5, 29, 0, 1, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 6571, -5, 5, 29, 0, 0, "", 1);// 300

		}

		public hex_PvpArenaAddon( Serial serial ) : base( serial )
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

	public class hex_PvpArenaAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new hex_PvpArenaAddon();
			}
		}

		[Constructable]
		public hex_PvpArenaAddonDeed()
		{
			Name = "hex_PvpArena";
		}

		public hex_PvpArenaAddonDeed( Serial serial ) : base( serial )
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