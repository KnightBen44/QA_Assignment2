using QA_Assignment2;
namespace TestProject1
{
    
    public class Tests
    {
        private Product _product { get; set; } = null!;
        private Product _product2 { get; set; } = null!;
        private Product _product3 { get; set;} = null!;

        //Start of Benjamin Bertoni Creation
        [SetUp]
        public void Setup()
        {
            //created for use in the tests
            //order is productId, costs, stock, and name

            _product = new Product(6,55.55,99, "Sweaters");
            _product2 = new Product(2, 1.0, -1, "Watches");
            _product3 = new Product(500007, 10000.00, 50009, "Hats");
           
        }

        [Test] //test that will come back valid using product 1
        public void GetProductID_Test1()
        {
            //Assign
            var productId = _product.productId;
            //Act
            var productResult = _product.GetProductId(productId);
            //Assert
            Assert.That(Is.Equals(productResult, "Valid"));
        }

       
        [Test]
        public void GetProductID_Test2() //test that will come back invalid using product 2
        {

            //Assign
            var productId = _product2.productId;
            //Act
            var productResult = _product2.GetProductId(productId);
            //Assert
            Assert.That(Is.Equals(productResult, "Valid"));
        }

        [Test]
        public void GetProductID_Test3() //test that will come back invalid using product 3
        {

            //Assign
            var productId = _product3.productId;
            //Act
            var productResult = _product3.GetProductId(productId);
            //Assert
            Assert.That(Is.Equals(productResult, "Valid"));
        }

        [Test]
        public void AddToProductID_Test1()  //test that will come back valid using product 1 but increase the productId
        {
            //Assign
            var productId = _product.productId;
            productId = productId + 200;
            //Act
            var productResult = _product.GetProductId(productId);
            //Assert
            Assert.That(Is.Equals(productResult, "Valid"));
        }
        

        [Test]
        public void AddToProductID_Test2() //test that will come back invalid using product 2 but decrease the productId
        {
           
            //Assign
            var productId = _product2.productId;
            productId = productId - 200;
            //Act
            var productResult = _product2.GetProductId(productId);
            //Assert
            Assert.That(Is.Equals(productResult, "Valid"));
        }

        [Test]
        public void AddToProductID_Test3() //test that will come back invalid using product 3 but decrease the productId
        {
            
            
            //Assign
            var productId = _product3.productId;
            productId = productId - 20000;
            //Act
            var productResult = _product3.GetProductId(productId);
            //Assert
            Assert.That(Is.Equals(productResult, "Valid"));
        
        }
        //End of Benjamin Bertoni Creation

    }
}