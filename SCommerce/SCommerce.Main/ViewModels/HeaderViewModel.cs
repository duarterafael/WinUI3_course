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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCommerce.Main.Services;
using SCommerce.Main.Views;

namespace SCommerce.Main.ViewModels
{
    public class HeaderViewModel
    {
        #region Private Fields

        private INavegationService _navegationService;

        #endregion Private Fields

        #region Public Constructors

        public HeaderViewModel(INavegationService navegationService)
        {
            _navegationService = navegationService;
        }

        #endregion Public Constructors

        #region Public Methods

        public void CardPageNavigation()
        {
            _navegationService.Navagate(typeof(CardPage));
        }

        #endregion Public Methods
    }
}