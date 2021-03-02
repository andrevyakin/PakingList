using System;
using System.Collections.Generic;
using System.Text;

namespace PakingList.Models
{
    internal class GoodsList
    {
        /// <summary> номер товара </summary>
        public int Number { get; set; }

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

    internal class CardGoods : GoodsList
    {
        //public GoodsList ItemListGoods { get; set; }

        /// <summary> Кол-во товара в груз месте </summary>
        public int PlaceGoodsQuantity { get; set; }
        
        /// <summary> Размеры товара (длина, высота, ширина) </summary>
        //public struct Dimensions
        //{
            /// <summary> Длина </summary>
            public double Length { get; set; }

            /// <summary> Высота </summary>
            public double Height { get; set; }

            /// <summary> Ширина </summary>
            public double Width { get; set; }

        //}

        /// <summary> Объем товара </summary>
        public double GoodsVolume { get; set; }

        /// <summary> Еденицы измерения (для размера товара) </summary>
        public string VolumeUnitQualifierName { get; set; }

        /// <summary> Единица Измерения Код Классификатора </summary>
        public int MeasureUnitQualifierCode { get; set; }

        /// <summary> Количество мест </summary>
        //public struct PlaceQuantity
        //{
           

            /// <summary> Количество грузовых мест, частично занятых товаром </summary>
            public double PlacesPartQuantity { get; set; }
        //}

        /// <summary> Сведения об упаковке товара </summary>
        //struct PackingInfo
        //{
            /// <summary> Код вида упаковки товаров в соответствии с классификатором видов груза, упаковки и упаковочных материалов. </summary>
            //public int PackingCode { get; set; }

            /// <summary> Количество упаковок.  </summary>
            public int PakingQuantity { get; set; }

            /// <summary> Описание упаковки. </summary>
            public string PackingDescription { get; set; }
        //}
    }
}
