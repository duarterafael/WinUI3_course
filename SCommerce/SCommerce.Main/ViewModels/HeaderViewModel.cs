/*
 * Copyright 2025 by Samsung Eletrônica da Amazônia Ltda. Todos os direitos reservados.
 *
 * Este software e seus códigos são confidenciais ("Informações Confidenciais")
 * e de propriedade da Samsung Eletrônica da Amazônia Ltda.
 * Você não deverá divulgar as Informações Confidenciais e deverá utilizá-las apenas de acordo
 * com os termos do acordo de licença entre você e a Samsung Eletrônica da Amazônia Ltda.
 *
 * Copyright 2025 by Samsung Eletrônica da Amazônia Ltda. All rights reserved.
 *
 * This software and its code are confidential ("Confidential Information")
 * and proprietary information of Samsung Eletrônica da Amazônia Ltda.
 * You shall not disclose such Confidential Information and shall use it only in accordance
 * with the terms of the license agreement you entered into with Samsung Eletrônica da Amazônia Ltda.
 */

using CommunityToolkit.Mvvm.ComponentModel;
using SCommerce.Main.Services;
using SCommerce.Main.Views;
using System.Collections.Specialized;

namespace SCommerce.Main.ViewModels
{
    public class HeaderViewModel : ObservableObject
    {
        #region Private Fields

        private readonly ICartService _cartService;
        private int _cartQuantity;
        private INavegationService _navegationService;

        #endregion Private Fields

        #region Public Constructors

        public HeaderViewModel(ICartService cartService, INavegationService navegationService)
        {
            _navegationService = navegationService;
            _cartService = cartService;

            _cartService.GetProducts().CollectionChanged += OnProductsCollectionChanged;
            _cartQuantity = _cartService.GetProducts().Count;
        }

        #endregion Public Constructors

        #region Public Properties

        public int CartQuantity
        {
            get => _cartQuantity;
            set => SetProperty(ref _cartQuantity, value);
        }

        #endregion Public Properties

        #region Public Methods

        public void CardPageNavigation()
        {
            _navegationService.Navagate(typeof(CardPage));
        }

        #endregion Public Methods

        #region Private Methods

        private void OnProductsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems is not null && e.OldItems.Count > 0)
            {
                CartQuantity -= e.OldItems.Count;
            }
            if (e.NewItems is not null && e.NewItems.Count > 0)
            {
                CartQuantity += e.NewItems.Count;
            }
        }

        #endregion Private Methods
    }
}