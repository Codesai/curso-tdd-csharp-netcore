using System;
using System.Collections.Generic;
using Gilded_rose;
using Xunit;

namespace KataGildedRose.Tests
{
    public class GildedRoseTest
    {
        [Fact]
        public void think_a_good_name_and_change_it()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Normal item", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal("Normal item", Items[0].Name);
        }
    }
}