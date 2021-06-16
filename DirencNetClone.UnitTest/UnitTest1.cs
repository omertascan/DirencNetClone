using Autofac.Extras.Moq;
using AutoFixture;
using DirencNetClone.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;
using Moq;
using DirencNetClone.Services;
using FluentAssertions;
using Xamarin.Forms.Xaml;
using Microsoft.SqlServer.Management.Smo;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Xamarin.Forms.Mocks;
using System;

namespace DirencNetClone.UnitTest


{

   
    [TestClass]
    public class Tests
    {
    
      
        private Fixture _fixture;
        public Tests() => _fixture = new Fixture();
        [SetUp]
        public void SetUp()
        {
            Xamarin.Forms.Mocks.MockForms.Init();
        }
        [Test]
        public async Task Push()
        {
            var root = new ContentPage();
            var page = new ContentPage();
            await root.Navigation.PushAsync(page);
            Assert.AreEqual(root.Navigation.NavigationStack.Last(), page);
        }
        [Test]

        //...

        public void LoadFromXaml()
        {
            var label = new Label();
            label.LoadFromXaml("<Label Text=\"GÝRÝÞ\" />");
            Assert.AreEqual("GÝRÝÞ", label.Text);
                }
        [Test]
        public async Task FadeTo()
        {
            var view = new BoxView();
            await view.FadeTo(0);
            Assert.AreEqual(0, view.Opacity);
        }
        [Test]
        public void OpenUri()
        {
            var expected = new Uri("https://www.google.com");
            var actual = default(Uri);

            MockForms.OpenUriAction = u => actual = u;
            Device.OpenUri(expected);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public async Task StartTimer()
        {
            var source = new TaskCompletionSource<bool>();
            Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
            {
                source.SetResult(true);
                return false;
            });

            Assert.IsTrue(await source.Task);
        }
        [Test]
        public void DefaultString()
        {
            MockForms.Init();

            var platformString = new OnPlatform<string>();
            platformString.Platforms.Add(new On
            {
                Value = "GÝRÝÞ",
                Platform = new[] { Device.RuntimePlatform }
            });

            Assert.AreEqual("GÝRÝÞ", (string)platformString);
        }
        [Test]
        public async Task PushModal()
        {
            var root = new ContentPage();
            var page = new ContentPage();
            await root.Navigation.PushModalAsync(page);
            Assert.AreEqual(root.Navigation.ModalStack.Last(), page);
        }
        [Test]
        public void CreatingCategoryViewModel_WhenSuccessfull_SelectedCategoryIsNull()
        {
            using(var mock = AutoMock.GetLoose())
            {

                var viewmodel = mock.Create<CategoryViewModel>();
                viewmodel.SelectedCategory.Should().NotBeNull();
            }
        }
        [Test]
        public void CreatingCartViewModel_WhenSuccessfull_InitializesPlaceOrderCommand()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var viewmodel = mock.Create<CartViewModel>();
                viewmodel.PlaceOrdersCommand.Should().NotBeNull();
                viewmodel.PlaceOrdersCommand.Should().BeOfType<Command<CartItemService>>();
            }
        }
        [Test]
        public void CreatingProductDetailsViewModel_WhenSuccessfull_SelectedProductItemIsNull()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var viewmodel = mock.Create<ProductDetailsViewModel>();
                viewmodel.SelectedProductItem.Should().NotBeNull();
            }
        }
     
        [Test]
        public void CreatingCategoryViewModel_WhenSuccessfull_TotalProductItemsIsNull()
        {
            using (var mock = AutoMock.GetLoose())
            {

                var viewmodel = mock.Create<CategoryViewModel>();
                viewmodel.TotalProductItems.Should();
            }
        }
    
    }



  
  
    
}