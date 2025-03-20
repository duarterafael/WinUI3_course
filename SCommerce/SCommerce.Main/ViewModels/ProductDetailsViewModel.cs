/*
 * Copyright 2024 by Samsung Eletrônica da Amazônia Ltda. Todos os direitos reservados.
 *
 * Este software e seus códigos são confidenciais ("Informações Confidenciais")
 * e de propriedade da Samsung Eletrônica da Amazônia Ltda.
 * Você não deverá divulgar as Informações Confidenciais e deverá utilizá-las apenas de acordo
 * com os termos do acordo de licença entre você e a Samsung Eletrônica da Amazônia Ltda.
 *
 * Copyright 2024 by Samsung Eletrônica da Amazônia Ltda. All rights reserved.
 *
 * This software and its code are confidential ("Confidential Information")
 * and proprietary information of Samsung Eletrônica da Amazônia Ltda.
 * You shall not disclose such Confidential Information and shall use it only in accordance
 * with the terms of the license agreement you entered into with Samsung Eletrônica da Amazônia Ltda.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCommerce.Main.ViewModels
{
    public class ProductDetailsViewModel
    {
        #region Public Constructors

        public ProductDetailsViewModel()
        {
            Title = "Product 1";
            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";
            Price = 999.93242349;
            Rating = 4;
            Images = new List<string>()
            {
                "/Assets/Images/product1.png",
                "/Assets/Images/product2.png",
                "/Assets/Images/product2.png",
            };
            SelectedImage = Images[0];
        }

        #endregion Public Constructors

        #region Public Properties

        public string Description { get; set; }
        public List<string> Images { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
        public string SelectedImage { get; set; }
        public string Title { get; set; }

        #endregion Public Properties
    }
}