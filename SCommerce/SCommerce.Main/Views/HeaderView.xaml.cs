/*
 * Copyright 2025 by Samsung Eletr�nica da Amaz�nia Ltda. Todos os direitos reservados.
 *
 * Este software e seus c�digos s�o confidenciais ("Informa��es Confidenciais")
 * e de propriedade da Samsung Eletr�nica da Amaz�nia Ltda.
 * Voc� n�o dever� divulgar as Informa��es Confidenciais e dever� utiliz�-las apenas de acordo
 * com os termos do acordo de licen�a entre voc� e a Samsung Eletr�nica da Amaz�nia Ltda.
 *
 * Copyright 2025 by Samsung Eletr�nica da Amaz�nia Ltda. All rights reserved.
 *
 * This software and its code are confidential ("Confidential Information")
 * and proprietary information of Samsung Eletr�nica da Amaz�nia Ltda.
 * You shall not disclose such Confidential Information and shall use it only in accordance
 * with the terms of the license agreement you entered into with Samsung Eletr�nica da Amaz�nia Ltda.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SCommerce.Main.Dependences;
using SCommerce.Main.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SCommerce.Main.Views
{
    public sealed partial class HeaderView : UserControl
    {
        #region Public Constructors

        public HeaderView()
        {
            this.InitializeComponent();
            this.DataContext = ViewModel;
        }

        #endregion Public Constructors

        #region Public Properties

        public HeaderViewModel ViewModel => DependecyManager.GetCurrent().GetInstance<HeaderViewModel>();

        #endregion Public Properties

        #region Private Methods

        private void BadgeAppBarButton_Click(object sender, RoutedEventArgs e)
        {
        }

        #endregion Private Methods
    }
}