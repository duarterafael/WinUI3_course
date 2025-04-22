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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCommerce.Main.Models;
using SCommerce.Main.Services;
using SCommerce.Main.Views;

namespace SCommerce.Main.ViewModels
{
    public class CartPageViewModel
    {
        #region Public Fields

        public readonly ICartService _cartService;

        #endregion Public Fields

        #region Private Fields

        private INavegationService _navegationService;

        #endregion Private Fields

        #region Public Constructors

        public CartPageViewModel(INavegationService navegationService, ICartService cartService)
        {
            _navegationService = navegationService;
            _cartService = cartService;

            CartItems = new ObservableCollection<CartItem>(_cartService.GetCartItems());
        }

        #endregion Public Constructors

        #region Public Properties

        public ObservableCollection<CartItem> CartItems { get; set; }

        #endregion Public Properties

        #region Public Methods

        public void GoBackNavigation()
        {
            _navegationService.GoBack();
        }

        #endregion Public Methods
    }
}