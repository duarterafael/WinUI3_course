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
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SCommerce.Main.Models;
using SCommerce.Main.Services;

namespace SCommerce.Main.ViewModels
{
    public class ProductDetailsViewModel : ObservableObject
    {
        #region Private Fields

        private readonly ICartService _cartService;

        private Product _product;

        private string _selectedImage;

        #endregion Private Fields

        #region Public Constructors

        public ProductDetailsViewModel(ICartService cartService)
        {
            this._cartService = cartService;
            AddToCardCommand = new RelayCommand(OnAddToCart, CanExecutedAddToCart);
            InitProducto();
        }

        #endregion Public Constructors

        #region Public Events

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion Public Events

        #region Public Properties

        public RelayCommand AddToCardCommand { get; private set; }

        public Product Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        public string SelectedImage
        {
            get => _selectedImage;
            set => SetProperty(ref _selectedImage, value);
        }

        #endregion Public Properties

        #region Private Methods

        private bool CanExecutedAddToCart()
        {
            return Product is not null;
        }

        private void InitProducto()
        {
            Product = new()
            {
                Title = "Product 1",
                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                Price = 999.93242349,
                Rating = 4,
                //Images = ["/Assets/Images/product1.png", "/Assets/Images/product2.png", "/Assets/Images/product3.png"]
            };
            //SelectedImage = Product.Images.FirstOrDefault();
        }

        private void OnAddToCart()
        {
            _cartService.AddProduct(Product);
        }

        #endregion Private Methods
    }
}