namespace Server.Items
{
	public class GlassShards : Item
	{
		[Constructable]
		public GlassShards() : base( 0x2240 )
		{
			Name = "Glass Shards";
			Stackable = false;
			Weight = 1.0;
		}

		public GlassShards( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}