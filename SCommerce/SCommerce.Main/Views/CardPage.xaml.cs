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

using Microsoft.UI.Xaml.Controls;
using SCommerce.Main.Dependences;
using SCommerce.Main.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SCommerce.Main.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CardPage : Page
    {
        #region Public Constructors

        public CardPage()
        {
            this.InitializeComponent();
            this.DataContext = ViewModel;
        }

        #endregion Public Constructors

        #region Public Properties

        public CardPageViewModel ViewModel => DependecyManager.GetCurrent().GetInstance<CardPageViewModel>();

        #endregion Public Properties
    }
}