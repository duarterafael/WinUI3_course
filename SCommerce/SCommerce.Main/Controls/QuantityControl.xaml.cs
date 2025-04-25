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
using System.Reflection.Metadata.Ecma335;
using System.Windows.Input;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SCommerce.Main.Controls
{
    public sealed partial class QuantityControl : UserControl
    {
        #region Public Fields

        // Using a DependencyProperty as the backing store for AddCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddCommandProperty =
            DependencyProperty.Register("AddCommand", typeof(ICommand), typeof(QuantityControl), new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for Quantity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register("Quantity", typeof(int), typeof(QuantityControl), new PropertyMetadata(0));

        // Using a DependencyProperty as the backing store for SubCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubCommandProperty =
            DependencyProperty.Register("SubCommand", typeof(ICommand), typeof(QuantityControl), new PropertyMetadata(null));

        #endregion Public Fields

        #region Public Constructors

        public QuantityControl()
        {
            this.InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Properties

        public ICommand AddCommand
        {
            get { return (ICommand)GetValue(AddCommandProperty); }
            set { SetValue(AddCommandProperty, value); }
        }

        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        public ICommand SubCommand
        {
            get { return (ICommand)GetValue(SubCommandProperty); }
            set { SetValue(SubCommandProperty, value); }
        }

        #endregion Public Properties
    }
}