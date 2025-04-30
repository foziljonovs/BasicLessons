using Constructor;

Product product = new Product("Shahar", "Juda shirin lekin juda ziyonli", 20000);
Console.WriteLine($"mahsulot nomi: {product.GetName()}," +
    $"\thaqida: {product.GetDescription()}" +
    $"\tnarxi: {product.GetPrice()}");

Product product1 = new Product("oqqand", 22000);
Console.WriteLine($"mahsulot nomi: {product1.GetName()}," +
    $"\thaqida: {product1.GetDescription()}" +
    $"\tnarxi: {product1.GetPrice()}");



Category category = new Category();
category.Name = "Meva";
category.Description = "Mevalar juda foydali";

Console.WriteLine($"1 - category, name : {category.Name}, description : {category.Description}");


Category category2 = new Category()
{
    Name = "Ichimlik suvi",
    Description = "Tabiiy ichimlik suvi"
};

Console.WriteLine($"2 - category, name : {category2.Name}, description : {category2.Description}");