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
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.CustomAttributes;
using SCommerce.Main.SCommerce_Main_XamlTypeInfo;

namespace SCommerce.Main.Dependences
{
    public class DepenecyManager : IDependencyManager
    {
        #region Private Fields

        private static IDependencyManager s_intance;
        private static IServiceProvider s_provider;

        #endregion Private Fields

        #region Public Methods

        public static IDependencyManager GetCurrent()
        {
            return s_intance ??= new DepenecyManager();
        }

        public static void Setup()
        {
            IServiceCollection servicesCollection = new ServiceCollection().AddSingleton(GetCurrent());
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