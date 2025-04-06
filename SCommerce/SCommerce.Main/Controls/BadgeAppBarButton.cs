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

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SCommerce.Main.Controls
{
    public sealed class BadgeAppBarButton : AppBarButton
    {
        #region Public Fields

        public static readonly DependencyProperty BadgeProperty =
            DependencyProperty.Register("Badge", typeof(string), typeof(BadgeAppBarButton), new PropertyMetadata(string.Empty));

        #endregion Public Fields

        #region Public Constructors

        public BadgeAppBarButton()
        {
            this.DefaultStyleKey = typeof(BadgeAppBarButton);
        }

        #endregion Public Constructors

        #region Public Properties

        public string Badge
        {
            get { return (string)GetValue(BadgeProperty); }
            set
            {
                SetValue(BadgeProperty, value);
            }
        }

        #endregion Public Properties
    }
}