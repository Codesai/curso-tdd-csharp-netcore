using System.Collections.Generic;
using NUnit.Framework;

namespace Gilded_rose.Test
{
    public class GildedRoseTest
    {
        [Test]
        public void fix_me()
        {
            IList<Item> items = new List<Item> { new Item("foo", 0, 0) };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Name, Is.EqualTo("fixme"));
        }

    }
}