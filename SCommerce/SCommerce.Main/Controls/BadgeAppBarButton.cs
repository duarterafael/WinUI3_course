/*
 * Copyright 2024 by Samsung Eletr�nica da Amaz�nia Ltda. Todos os direitos reservados.
 *
 * Este software e seus c�digos s�o confidenciais ("Informa��es Confidenciais")
 * e de propriedade da Samsung Eletr�nica da Amaz�nia Ltda.
 * Voc� n�o dever� divulgar as Informa��es Confidenciais e dever� utiliz�-las apenas de acordo
 * com os termos do acordo de licen�a entre voc� e a Samsung Eletr�nica da Amaz�nia Ltda.
 *
 * Copyright 2024 by Samsung Eletr�nica da Amaz�nia Ltda. All rights reserved.
 *
 * This software and its code are confidential ("Confidential Information")
 * and proprietary information of Samsung Eletr�nica da Amaz�nia Ltda.
 * You shall not disclose such Confidential Information and shall use it only in accordance
 * with the terms of the license agreement you entered into with Samsung Eletr�nica da Amaz�nia Ltda.
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