using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PakingList.Models;
using PakingList.Models.Goods;
using PakingList.Services.Interfaces;
using PakingList.ViewModels.Base;

namespace PakingList.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private readonly IUserDialog _UserDialog;
        private readonly IDataService _DataService;

        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "Главное окно";

        /// <summary>Заголовок окна</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion

        #region Status : string - Статус

        /// <summary>Статус</summary>
        private string _Status = "Готов!";

        /// <summary>Статус</summary>
        public string Status { get => _Status; set => Set(ref _Status, value); }

        #endregion

        #region Обработка модели товаров

        public ObservableCollection<GoodsNumber> GoodsNumbers { get; }

        #region SeltctedGoods : GoodsNumber - Выбранный товар

        /// <summary>Выбранный товар</summary>
        private GoodsNumber _SeltctedGoods;

        /// <summary>Выбранный товар</summary>
        public GoodsNumber SeltctedGoods
        {
            get => _SeltctedGoods;
            set => Set(ref _SeltctedGoods, value);
        }

        #endregion

        #endregion

        public MainWindowViewModel(IUserDialog UserDialog, IDataService DataService)
        {
            _UserDialog = UserDialog;
            _DataService = DataService;


            int goods_index = 1;
            var goods = Enumerable.Range(1, 20).Select(i => new CardGoods()
            {
                
                    GoodsDescription = $"Товар {goods_index}",
                    GoodMarking = new Random(100000000).Next(),
                    GoodsQuantity = goods_index * 5.0,
                    MeasureUnitQualifierName = "шт",
                    GrossWeightQuantity = goods_index++*100,
                    PackingDescription = "Коробка"
            });

            var goodsNumbers = Enumerable.Range(1, 20).Select(i => new GoodsNumber()
            {
                Number = i,
                GoodsNumbers = new ObservableCollection<CardGoods>(goods)
            });

            GoodsNumbers = new ObservableCollection<GoodsNumber>(goodsNumbers);
            

        }
    }
}
