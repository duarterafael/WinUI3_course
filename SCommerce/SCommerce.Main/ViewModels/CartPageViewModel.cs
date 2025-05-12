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
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using SCommerce.Main.Models;
using SCommerce.Main.Services;
using SCommerce.Main.Views;

namespace SCommerce.Main.ViewModels
{
    public class CartPageViewModel : ObservableObject
    {
        #region Public Fields

        public readonly ICartService _cartService;

        public ObservableCollection<CartItemViewModel> _cartItems = new();

        #endregion Public Fields

        #region Private Fields

        private INavegationService _navegationService;
        private string _selectedStep;
        private List<string> _steps;

        private int count = 0;

        #endregion Private Fields

        #region Public Constructors

        public CartPageViewModel(INavegationService navegationService, ICartService cartService)
        {
            _navegationService = navegationService;
            _cartService = cartService;

            _cartService.GetProducts().CollectionChanged += Product_CollectionChanged;

            List<CartItemViewModel> items = _cartService.GetCartItems().Select(e => CartItemViewModel.Create(e, cartService)).ToList();
            CartItems = new ObservableCollection<CartItemViewModel>(items);

            Steps = new() { "Ckeckout", "Adress", "Payment" };

            SelectedStep = Steps.First();
        }

        #endregion Public Constructors

        #region Public Properties

        public ObservableCollection<CartItemViewModel> CartItems
        {
            get => _cartItems;
            set => SetProperty(ref _cartItems, value);
        }

        public string SelectedStep
        {
            get { return _selectedStep; }
            set { SetProperty(ref _selectedStep, value); }
        }

        public List<string> Steps
        {
            get { return _steps; }
            set { SetProperty(ref _steps, value); }
        }

        #endregion Public Properties

        #region Public Methods

        public void ChangedSelectedStep()
        {
            count++;
            SelectedStep = Steps[count % Steps.Count];
        }

        public void GoBackNavigation()
        {
            _navegationService.GoBack();
        }

        #endregion Public Methods

        #region Private Methods

        private void Product_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (sender is not null && sender is ObservableCollection<Product> products)
            {
                if (products.Count() == 0)
                {
                    CartItems = new ObservableCollection<CartItemViewModel>();
                }
            }
        }

        #endregion Private Methods
    }
}