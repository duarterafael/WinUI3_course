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
using System.Collections.ObjectModel;

namespace SCommerce.Main.Models
{
    public class CartItem : ObservableObject
    {
        #region Private Fields

        private string _image = string.Empty;
        private double _price = 0;
        private int _quantity = 0;
        private string _title = string.Empty;

        #endregion Private Fields

        #region Public Properties

        public string Image
        {
            get => _image;
            set => SetProperty(ref _image, value);
        }

        public ObservableCollection<string> Images { get; set; }

        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public int Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion Public Properties
    }
}