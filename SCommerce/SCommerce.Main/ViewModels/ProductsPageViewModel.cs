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
using SCommerce.Main.Models;
using SCommerce.Main.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SCommerce.Main.ViewModels
{
    public class ProductsPageViewModel : ObservableObject
    {
        #region Private Fields

        private readonly INavegationService _navegationService;
        private readonly IProdcutService _productService;

        private ObservableCollection<Product> _items;

        #endregion Private Fields

        #region Public Constructors

        public ProductsPageViewModel(INavegationService navegationService, IProdcutService prodcutService)
        {
            this._navegationService = navegationService;
            this._productService = prodcutService;
        }

        #endregion Public Constructors

        #region Public Properties

        public ObservableCollection<Product> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        #endregion Public Properties
    }
}