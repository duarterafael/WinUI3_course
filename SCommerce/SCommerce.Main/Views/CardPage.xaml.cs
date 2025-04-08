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