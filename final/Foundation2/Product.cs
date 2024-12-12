public class Product
{
    private string _name;
    private int _productID;
    private decimal _pricePerUnit;
    private int _quantityOfProduct;
    
    public Product(string name, int productID, decimal pricePerUnit, int quantityofproduct)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantityOfProduct = quantityofproduct;
    }
    public decimal CalculateTotalCost()
    {
        return _pricePerUnit * _quantityOfProduct;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetProductID()
    {
        return _productID;
    }
}