namespace PakingList.Models.Goods
{
    internal class GoodsList
    {
        
        /// <summary> Описание Товара </summary>
        public string GoodsDescription { get; set; }

        /// <summary> Артикул </summary>
        public int GoodMarking { get; set; }

        /// <summary> Количество товаров </summary>
        public double GoodsQuantity { get; set; }

        /// <summary> Еденицы измерения (количество) </summary>
        public string MeasureUnitQualifierName { get; set; }

        /// <summary> Вес брутто (кг) </summary>
        public double GrossWeightQuantity { get; set; }

        /// <summary> Вес нетто (кг) </summary>
        public double NetWeightQuantity { get; set; }

        /// <summary> Количество грузовых мест товара (при описании товара указывается количество полностью занимаемых товаром мест) </summary>
        public int PlacesQuantity { get; set; }

        /// <summary> Описание вида грузовых мест (коробок, упаковок, паллет и т.д.) </summary>
        public string PlacesDescription { get; set; }

        /// <summary> Код вида упаковки товаров в соответствии с классификатором видов груза, упаковки и упаковочных материалов. </summary>
        public string PackingCode { get; set; }
    }
}