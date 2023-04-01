using Fields;

Product product = new Product();
product.productId = 12;
product.productName = "Mobile";
product.price = 3000;
product.quantityInStock = 1000;

Product product2 = new Product();
product2.productId = 13;
product2.productName = "Mobile2";
product2.price = 3000;
product2.quantityInStock = 1000;

Product product3 = new Product();
product3.productId = 14;
product3.productName = "Mobile3";
product3.price = 3000;
product3.quantityInStock = 1000;

Console.WriteLine(product.productName + " " + product2.productName + " " + product3.productName);

// Access Modifiers of fields
//  refer excel.

// static field
Console.WriteLine(Product.count++);     // no need to create object to acces stativ field.
Product.count = 300;
Console.WriteLine(Product.count);

// constant field
Console.WriteLine(Product.no);          // no need to create object to access constant field.
                                        // Product.no = 100;                    // error cannot change value of const.

// readonly fields.
Console.WriteLine(product.age);
Console.WriteLine(product2.age);
Console.WriteLine(product3.age);
//Console.WriteLine(Product.age);       // cannot be accessed using class directly.
