
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
	public class SinkAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {18, 1, 0, 0}// 4	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SinkAddonDeed();
			}
		}

		[ Constructable ]
		public SinkAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 8, 0, 1, 0, 0, -1, "sink", 1);// 1
			AddComplexComponent( (BaseAddon) this, 18, 1, 1, 0, 0, -1, "sink", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2884, 1, 1, 9, 0, -1, "sink", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1993, 1, 1, 0, 0, -1, "sink", 1);// 5
			AddComplexComponent( (BaseAddon) this, 10646, 1, 1, 0, 0, -1, "sink", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4100, 1, 1, 15, 0, -1, "faucet", 1);// 7

		}

		public SinkAddon( Serial serial ) : base( serial )
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

	public class SinkAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SinkAddon();
			}
		}

		[Constructable]
		public SinkAddonDeed()
		{
			Name = "Sink Deed";
		}

		public SinkAddonDeed( Serial serial ) : base( serial )
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