using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        [Fact]
        public void MenuEntreesShouldContainExpectedItems()
        {
            var entrees = new List<IOrderItem>(Menu.AllEntrees);
            Assert.Collection(
                entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
            
        }

        [Fact]
        public void MenuSidesShouldContainExpectedItems()
        {
            var sides = new List<IOrderItem>(Menu.AllSides);
            Assert.Collection(
                sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        [Fact]
        public void MenuDrinksShouldContainExpectedItems()
        {
            var drinks = new List<IOrderItem>(Menu.AllDrinks);
            Assert.Collection(
                drinks,
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void MenuAllShouldContainExpectedItems()
        {
            var all = new List<IOrderItem>(Menu.All);
            Assert.Collection(
                all,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void NullSearchShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.Search(items, "");
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }
        
        [Fact]
        public void NullFilterByPriceShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByPrice(items, null, null);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
            );
        }

        [Fact]
        public void NullFilterByCategoryShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByCategory(items, null);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void NullFilterByCaloriesShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByCalories(items, null, null);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void FilterByCaloriesOnlyMaxSet()
        {
            var items = Menu.All;
            items = Menu.FilterByCalories(items, null, 1);
            Assert.Collection(
                items,
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void FilterByCaloriesOnlyMinSet()
        {
            var items = Menu.All;
            items = Menu.FilterByCalories(items, 893, null);
            Assert.Collection(
                items,
                (rr) => { Assert.IsType<RustlersRibs>(rr); }
                );
        }

        [Fact]
        public void FilterByPriceOnlyMaxSet()
        {
            var items = Menu.All;
            items = Menu.FilterByPrice(items, null, .3);
            Assert.Collection(
                items,
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void FilterByPriceOnlyMinSet()
        {
            var items = Menu.All;
            items = Menu.FilterByPrice(items, 7.4, null);
            Assert.Collection(
                items,
                (rr) => { Assert.IsType<RustlersRibs>(rr); }
                );
        }

        [Fact]
        public void FilterByPriceMinAndMax()
        {
            var items = Menu.All;
            items = Menu.FilterByPrice(items, 1.79, 2.01);
            Assert.Collection(
                items,
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); }
                );
        }

        [Fact]
        public void FilterByCaloriesMinAndMax()
        {
            var items = Menu.All;
            items = Menu.FilterByCalories(items, 432, 444);
            Assert.Collection(
                items,
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); }
                );
        }

        [Fact]
        public void FilterByEntreeShouldContainItems()
        {
            var items = Menu.All;
            var s = new List<string>();
            s.Add("Entree");
            items = Menu.FilterByCategory(items, s);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        [Fact]
        public void FilterBySideShouldContainItems()
        {
            var items = Menu.All;
            var s = new List<string>();
            s.Add("Side");
            items = Menu.FilterByCategory(items, s);
            Assert.Collection(
                items,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        [Fact]
        public void FilterByDrinkShouldContainItems()
        {
            var items = Menu.All;
            var s = new List<string>();
            s.Add("Drink");
            items = Menu.FilterByCategory(items, s);
            Assert.Collection(
                items,
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void FilterByEntreeAndSideShouldContainItems()
        {
            var items = Menu.All;
            var s = new List<string>();
            s.Add("Entree");
            s.Add("Side");
            items = Menu.FilterByCategory(items, s);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        [Fact]
        public void FilterByEntreeAndDrinkShouldContainItems()
        {
            var items = Menu.All;
            var s = new List<string>();
            s.Add("Entree");
            s.Add("Drink");
            items = Menu.FilterByCategory(items, s);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void FilterBySideAndDrinkShouldContainItems()
        {
            var items = Menu.All;
            var s = new List<string>();
            s.Add("Side");
            s.Add("Drink");
            items = Menu.FilterByCategory(items, s);
            Assert.Collection(
                items,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        } 

        [Fact]
        public void FilterByEntreeAndSideAndDrinkShouldContainAll()
        {
            var items = Menu.All;
            var s = new List<string>();
            s.Add("Entree");
            s.Add("Side");
            s.Add("Drink");
            items = Menu.FilterByCategory(items, s);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void MaxLimitForCaloriesShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByCalories(items, null, 1000);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void MinLimitForCaloriesShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByCalories(items, 0, null);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void MaxLimitForPriceShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByPrice(items, null, 10);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void MinLimitForPriceShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByPrice(items, 0, null);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void MaxAndMinLimitForPriceShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByPrice(items, 0, 10);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void MaxAndMinCaloriesForPriceShouldContainAll()
        {
            var items = Menu.All;
            items = Menu.FilterByPrice(items, 0, 1000);
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void SearchAllCapsShouldContainItem()
        {
            var items = Menu.All;
            items = Menu.Search(items, "ANGRY");
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); }
                );
        }

        [Fact]
        public void SearchAllLowerCaseShouldContainItem()
        {
            var items = Menu.All;
            items = Menu.Search(items, "ANGRY");
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); }
                );
        }

        [Fact]
        public void SearchShouldContainItem()
        {
            var items = Menu.All;
            items = Menu.Search(items, "Angry Chicken");
            Assert.Collection(
                items,
                (ac) => { Assert.IsType<AngryChicken>(ac); }
                );
        }

        
    }
}
