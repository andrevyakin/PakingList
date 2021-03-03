using System.Collections.Generic;

namespace PakingList.Models.Goods
{
    internal class GoodsNumber
    {
        /// <summary> номер товара </summary>
        public int Number { get; set; }

        public IList<CardGoods> GoodsNumbers { get; set; }
    }
}
