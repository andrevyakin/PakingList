using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PakingList.Models;
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

        public ObservableCollection<CardGoods> Goods { get; }

        #region SeltctedGoog : CardGoods - Выбранный товар

        /// <summary>Выбранный товар</summary>
        private CardGoods _SeltctedGoogs;

        /// <summary>Выбранный товар</summary>
        public CardGoods SeltctedGoog
        {
            get => _SeltctedGoogs;
            set => Set(ref _SeltctedGoogs, value);
        }

        #endregion

        #endregion

        public MainWindowViewModel(IUserDialog UserDialog, IDataService DataService)
        {
            _UserDialog = UserDialog;
            _DataService = DataService;

            var goods = Enumerable.Range(1, 10).Select(i => new CardGoods()
            {
                
                    Number = i,
                    GoodsDescription = $"Товар {i}",
                    GoodMarking = new Random(100000000).Next(),
                    GoodsQuantity = i*5.0,
                    MeasureUnitQualifierName = "шт",
                    GrossWeightQuantity = 100,
                    PackingDescription = "Коробка"
                
            });

            Goods = new ObservableCollection<CardGoods>(goods);
            

        }
    }
}
