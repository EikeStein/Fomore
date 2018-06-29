﻿using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Fomore.UI.ViewModel.CreatureEditor.Behaviours {
    public class FlipVeticalBehaviour : BaseBehaviour
    {
        /// <inheritdoc />
        public override ImageSource Image { get; } = new BitmapImage(new Uri("/assets/images/flipvertical.png", UriKind.Relative));

        /// <inheritdoc />
        public override BehaviourType BehaviourType { get; } = BehaviourType.Operations;
    }
}