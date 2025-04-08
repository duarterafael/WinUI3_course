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

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using SCommerce.Main.Dependences;
using SCommerce.Main.Services;
using SCommerce.Main.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SCommerce.Main
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        #region Private Fields

        private Window? m_window;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        #endregion Public Constructors

        #region Protected Properties

        protected Frame RootFrame { get; private set; }

        #endregion Protected Properties

        #region Protected Methods

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            DependecyManager.Setup();

            INavegationService navegationService = DependecyManager.GetCurrent().GetInstance<INavegationService>();
            navegationService.Navagate(typeof(ProductDetailsPage));

            var appShell = new AppShell();
            appShell.SetFrame(navegationService.GetRootFrame());

            m_window = new MainWindow();
            m_window.Content = appShell;

            m_window.Activate();
        }

        #endregion Protected Methods
    }
}