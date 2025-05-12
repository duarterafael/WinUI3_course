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
using Windows.Foundation;

namespace SCommerce.Main.Controls
{
    public class SpaceBetweenPanel : Panel
    {
        #region Private Fields

        private double itemWidth = 0;

        #endregion Private Fields

        #region Protected Methods

        protected override Size ArrangeOverride(Size finalSize)
        {
            double spaceBetween = (finalSize.Width - itemWidth) / (Children.Count - 1);
            var size = new Size(0, 0);
            foreach (var item in Children)
            {
                if (item.DesiredSize.Height > size.Height)
                {
                    size.Height = item.DesiredSize.Height;
                }
                item.Arrange(new Rect(size.Width, 0, item.DesiredSize.Width, item.DesiredSize.Height));
                size.Width += item.DesiredSize.Width + spaceBetween;
            }
            return size;
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            var remainingSize = availableSize;
            var size = new Size(0, 0);
            foreach (var item in Children)
            {
                item.Measure(availableSize);
                if (item.DesiredSize.Height > size.Height)
                {
                    size.Height = item.DesiredSize.Height;
                }
                size.Width += item.DesiredSize.Width;
                remainingSize.Width -= item.RenderSize.Width;
            }
            itemWidth = size.Width;
            return size;
        }

        #endregion Protected Methods
    }
}