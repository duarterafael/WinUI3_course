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

        private int _quantity = 0;

        #endregion Private Fields

        #region Public Properties

        public Product Product { get; set; } = new();

        public int Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        #endregion Public Properties
    }
}