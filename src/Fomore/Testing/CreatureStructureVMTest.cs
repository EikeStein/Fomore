﻿using Core;
using Fomore.UI.ViewModel.Data;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    class CreatureStructureVMTest
    {
        [Test]
        public void CreatureStructure_Consturctor_Testing()
        {
            var creature = new Creature { Name = "Dog", Description = "Can run" };
            var creatureVM = new CreatureVM(creature);
            var creatureSturStructure = new CreatureStructure();

        }
    }
}