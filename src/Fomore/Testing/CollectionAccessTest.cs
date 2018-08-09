﻿using System;
using System.Collections.Generic;
using Core;
using Fomore.UI.ViewModel.Helper;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    class CollectionAccessTest
    {
        [Test]
        public void CollectionAccess_AddingCollectionTest_Adding()
        {
            var creature = new Creature { Name = "Dog", Description = "Can run" };
            var creatureTwo = new Creature { Name = "turtle", Description = "Can crawl" };
            var creatureThree = new Creature { Name = "perrot", Description = "Can fly" };
            List<Creature> creatureList = new List<Creature>();
            creatureList.Add(creature);
            creatureList.Add(creatureTwo);
            CollectionAccess<Creature> collectionAcces = ReadOnlyObservableCollection<Creature>.Create(creatureList);
            var beforAddingCollection = collectionAcces.Collection.Count;
            collectionAcces.Add(creatureThree);
            var afterAddingCollection = collectionAcces.Collection.Count;
            Assert.AreNotEqual(beforAddingCollection, afterAddingCollection);
        }

        [Test]
        public void CollectionAccess_RemovingCollectionTest_Removing()
        {
            var creature = new Creature { Name = "Dog", Description = "Can run" };
            var creatureTwo = new Creature { Name = "turtle", Description = "Can crawl" };
            List<Creature> creatureList = new List<Creature>();
            creatureList.Add(creature);
            creatureList.Add(creatureTwo);
            CollectionAccess<Creature> collectionAcces = ReadOnlyObservableCollection<Creature>.Create(creatureList);
            var beforRemovingCollection = collectionAcces.Collection.Count;
            collectionAcces.Remove(creatureTwo);
            var afterRemovingCollection = collectionAcces.Collection.Count;

            Assert.AreNotEqual(beforRemovingCollection, afterRemovingCollection);
        }

        [Test]
        public void CollectionAccess_ClearingCollectionTest_Clearing()
        {
            var creature = new Creature { Name = "Dog", Description = "Can run" };
            var creatureTwo = new Creature { Name = "turtle", Description = "Can crawl" };
            List<Creature> creatureList = new List<Creature>();
            creatureList.Add(creature);
            creatureList.Add(creatureTwo);
            CollectionAccess<Creature> collectionAcces = ReadOnlyObservableCollection<Creature>.Create(creatureList);
            var beforClearningCollection = collectionAcces.Collection.Count;
            collectionAcces.Clear();
            var afterClearingCollection = collectionAcces.Collection.Count;
            Assert.AreNotEqual(beforClearningCollection, afterClearingCollection);
        }
    }
}