using System.Collections;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles 
{ 
	public class SBSmithTools: SBInfo 
	{
        private readonly List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
        private readonly IShopSellInfo m_SellInfo = new InternalSellInfo();

	    public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{
                Add(new GenericBuyInfo(typeof(IronIngot), 5, Utility.RandomMinMax(15, 20), 0x1BF2, 0));
                Add(new GenericBuyInfo(typeof(Tongs), 13, Utility.RandomMinMax(15, 20), 0xFBB, 0)); 

			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				Add( typeof( Tongs ), 7 ); 
				Add( typeof( IronIngot ), 4 ); 
			} 
		} 
	} 
}