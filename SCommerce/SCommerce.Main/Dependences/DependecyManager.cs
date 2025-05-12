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
using Microsoft.Extensions.DependencyInjection;
using SCommerce.Main.Services;
using SCommerce.Main.ViewModels;

namespace SCommerce.Main.Dependences
{
    public class DependecyManager : IDependencyManager
    {
        #region Private Fields

        private static IDependencyManager s_intance;
        private static IServiceProvider s_provider;

        #endregion Private Fields

        #region Public Methods

        public static IDependencyManager GetCurrent()
        {
            return s_intance ??= new DependecyManager();
        }

        public static void Setup()
        {
            IServiceCollection servicesCollection = new ServiceCollection()
                .AddSingleton(GetCurrent())
                .AddSingleton<INavegationService, NavegationService>()
                .AddSingleton<ICartService, CartService>()
                .AddSingleton<IProdcutService, ProductService>()
                .AddSingleton<ProductDetailsViewModel>()
                .AddSingleton<ProductsPageViewModel>()
                .AddSingleton<CartPageViewModel>()
                .AddSingleton<HeaderViewModel>();

            //.AddSingleton<CartService>();

            s_provider = servicesCollection.BuildServiceProvider();
        }

        public object GetInstace(Type type)
        {
            return ActivatorUtilities.GetServiceOrCreateInstance(s_provider, type);
        }

        public T GetInstance<T>()
        {
            return (T)GetInstace(typeof(T));
        }

        #endregion Public Methods
    }
}