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
using CommunityToolkit.Mvvm.Input;
using SCommerce.Main.Models;
using SCommerce.Main.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCommerce.Main.ViewModels
{
    public class CartItemViewModel : ObservableObject
    {
        #region Private Fields

        private readonly ICartService _cartService;

        private Product _product = new Product();

        private int _quantity = 0;

        #endregion Private Fields

        #region Public Constructors

        public CartItemViewModel(ICartService cartService)
        {
            _cartService = cartService;
            AddCommand = new RelayCommand(AddAction);
            SubtractCommand = new RelayCommand(Subtractction);
        }

        #endregion Public Constructors

        #region Public Properties

        public RelayCommand AddCommand { get; private set; }
        public string Image => Product.Images[0];
        public double Price => Product.Price;

        public Product Product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { SetProperty(ref _quantity, value); }
        }

        public RelayCommand SubtractCommand { get; private set; }
        public string Title => Product.Title;

        #endregion Public Properties

        #region Public Methods

        public static CartItemViewModel Create(CartItem model, ICartService cartService)
        {
            return new CartItemViewModel(cartService)
            {
                Product = model.Product,
                Quantity = model.Quantity,
            };
        }

        #endregion Public Methods

        #region Private Methods

        private void AddAction()
        {
            Quantity++;
            _cartService.AddProduct(Product);
        }

        private void Subtractction()
        {
                Quantity--;
                _cartService.SubtractProduct(Product);
           
        }

        #endregion Private Methods
    }
}