﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Moq;
using Sitecore.Collections;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace BasicCompany.Feature.Navigation.Tests
{
    internal static class ItemMock
    {
        public static Mock<Item> New()
        {
            var mock = new Mock<Item>(ID.NewID, ItemData.Empty, Mock.Of<Database>());
            var childList = new Mock<ChildList>(mock.Object, Enumerable.Empty<Item>());
            mock.Setup(x => x.Children).Returns(childList.Object);
            return mock;
        }

        public static Mock<Item> New(string name)
        {
            var mock = New();
            mock.Setup(x => x.Name).Returns(name);
            return mock;
        }

        public static Item NewObject()
        {
            return New().Object;
        }

        public static IReadOnlyCollection<Item> NewListOf(int count)
        {
            var list = new Collection<Item>();
            while (count > 0)
            {
                --count;
                list.Add(NewObject());
            }

            return list;
        }
    }
}