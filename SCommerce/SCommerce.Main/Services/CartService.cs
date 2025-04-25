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

using SCommerce.Main.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCommerce.Main.Services
{
    public class CartService : ICartService
    {
        #region Public Constructors

        public CartService()
        {
            _products = new();
        }

        #endregion Public Constructors

        #region Public Properties

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            private set { _products = value; }
        }

        #endregion Public Properties

        #region Private Properties

        private ObservableCollection<Product> _products { get; set; }

        #endregion Private Properties

        #region Public Methods

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<CartItem> GetCartItems()
        {
            Dictionary<String, CartItem> cart = new Dictionary<String, CartItem>();
            foreach (var product in Products)
            {
                if (cart.ContainsKey(product.Title))
                {
                    cart[product.Title].Quantity++;
                }
                else
                {
                    var cartItem = new CartItem
                    {
                        Product = product,
                        Quantity = 1
                    };
                    cart.Add(product.Title, cartItem);
                }
            }
            return cart.Values.ToList();
        }

        public ObservableCollection<Product> GetProducts()
        {
            return _products;
        }

        public void SubtractProduct(Product product)
        {
            _products.Remove(product);
        }

        #endregion Public Methods
    }
}